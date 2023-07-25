using DocSmart.Models.DocumentacaoTestes;
using DocSmart.Models.PlanoDeTestes;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace DocSmart.Controllers
{
    public class ControleTestesController
    {

        Excel.Application excelApp;
        Excel.Workbook planoWorkbook;
        Excel.Worksheet planoWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        DocumentacaoTesteModel documentacaoTeste;

        string newPath;

        public ControleTestesController(string pathPlanoTeste, string newPath)
        {
            string templatePath = "C:\\Projeto - Relatorio Estagio\\DocSmart - WF\\DocSmart\\Arquivos\\Templates\\ControleTestes.xlsx";
            
            excelApp = new Excel.Application();
            planoWorkbook = excelApp.Workbooks.Open(pathPlanoTeste);
            planoWorksheet = (Excel.Worksheet)planoWorkbook.ActiveSheet;

            templateWorkbook = excelApp.Workbooks.Open(templatePath);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;

            newWorkbook = excelApp.Workbooks.Add();
            newWorksheet = (Excel.Worksheet)newWorkbook.ActiveSheet;

            documentacaoTeste = DocumentacaoTesteModel.Instance;

            this.newPath = newPath;
        }

        public void GeraControleTestes()
        {
            LerExcel();
            CriaWorkbook();
            PreencheExcel();
            SalvarNovo();
        }

        private void LerExcel()
        {
            try
            {
                const string CELULA_TEMPLATE_CLIENTE = "C3";
                const string CELULA_TEMPLATE_DEMANDA = "C4";

                documentacaoTeste.Cliente = planoWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value;
                documentacaoTeste.Titulo = planoWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value;

                for (int numLinha = 8; ; numLinha++)
                {
                    if (planoWorksheet.Range[$"B{numLinha}"].Value == null
                        || planoWorksheet.Range[$"B{numLinha}"].Value == string.Empty)
                    {
                        break;
                    }

                    if (planoWorksheet.Range[$"B{numLinha}"].Value.Contains("Cen"))
                    {
                        DocumentacaoCenarioModel documentacaoCenarioModel = new DocumentacaoCenarioModel();

                        documentacaoCenarioModel.Cenario = planoWorksheet.Range[$"B{numLinha}"].Value;
                        documentacaoCenarioModel.Modulo = planoWorksheet.Range[$"C{numLinha}"].Value;
                        documentacaoTeste.Cenarios.Add(documentacaoCenarioModel);
                    }
                }
                
            }
            finally
            {
                planoWorkbook.Close();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(planoWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(planoWorkbook);

            }
        }

        private void CriaWorkbook()
        {
            templateWorksheet.Cells.Copy(Type.Missing);
            newWorksheet.Cells.PasteSpecial(Excel.XlPasteType.xlPasteAll);

            
        }

        private void PreencheExcel()
        {
            const string LINHA_TEMPLATE_HEADER = "A2:H2";
            int numLinha = 2;
            foreach (var cenario in documentacaoTeste.Cenarios)
            {
                Excel.Range sourceRange = templateWorksheet.Range[LINHA_TEMPLATE_HEADER];
                Excel.Range destinationRange = newWorksheet.Range[$"A{numLinha}"];
                sourceRange.Copy(destinationRange);

                newWorksheet.Range[$"A{numLinha}"].Value = $"{cenario.Modulo}";
                newWorksheet.Range[$"B{numLinha}"].Value = $"{cenario.Cenario}";
                numLinha++;
            }

            
        }


        private void SalvarNovo()
        {
            try
            {
                MessageBox.Show(newPath);
                newWorkbook.SaveAs(newPath + $"\\{documentacaoTeste.Titulo} - Controle de Teste.xlsx", Excel.XlFileFormat.xlWorkbookDefault);
            }
            finally
            {
                // Fechar as pastas de trabalho e o aplicativo Excel
                templateWorkbook.Close();
                newWorkbook.Close();
                excelApp.Quit();

                // Liberar recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                GC.Collect();
                MessageBox.Show("Células copiadas com sucesso para o novo arquivo Excel!");
            }
        }
    }
}
