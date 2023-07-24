using DocSmart.Models.PlanoDeTestes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace DocSmart.Controllers
{
    internal class PlanoDeTestesController
    {
        string currentDirectory;
        string pathProjeto;
        string templatePath;

        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        PlanoDeTestesModel planoTeste;
        int numCenario;
        string newPath;

        public PlanoDeTestesController(string newPath)
        {
            currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.FullName;
            pathProjeto = Directory.GetParent(Directory.GetParent(currentDirectory)?.FullName)?.FullName;
            templatePath = $"{pathProjeto}\\DocSmart\\Arquivos\\Templates\\PlanoDeTestes.xlsx";


            excelApp = new Excel.Application();
            templateWorkbook = excelApp.Workbooks.Open(templatePath);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;

            newWorkbook = excelApp.Workbooks.Add();
            newWorksheet = (Excel.Worksheet)newWorkbook.ActiveSheet;

            planoTeste = PlanoDeTestesModel.Instance;
            numCenario = 1;
            this.newPath = newPath;
        }

        public void GerarPlanoTestes()
        {
            try
            {
                CriaWorkbook();
                CriarDescricaoDocumento();
                int i = 8;
                foreach (var cenario in planoTeste.Cenarios)
                {
                    foreach (var modulo in cenario.Header.Modulos)
                    {
                        CriarTituloCenario(i++, cenario.Header, modulo);
                        foreach (var passo in cenario.Passos)
                        {
                            CriarPassoCenario(i++, passo);
                        }
                    }

                }
            }
            finally
            {
                SalvarNovoPlano();
            }

        }

        private void CriaWorkbook()
        {
            templateWorksheet.Cells.Copy(Type.Missing);
            newWorksheet.Cells.PasteSpecial(Excel.XlPasteType.xlPasteAll);
        }

        private void CriarDescricaoDocumento()
        {
            const string CELULA_TEMPLATE_CLIENTE = "C3";
            const string CELULA_TEMPLATE_DEMANDA = "C4";
            const string CELULA_TEMPLATE_DESCRICAO = "C5";

            newWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value = planoTeste.HeaderPlanoTeste.Cliente;

            newWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value =
                $"{planoTeste.HeaderPlanoTeste.CodigoDemanda} - {planoTeste.HeaderPlanoTeste.Titulo}";

            newWorksheet.Range[CELULA_TEMPLATE_DESCRICAO].Value = planoTeste.HeaderPlanoTeste.Descricao;

        }

        private void CriarTituloCenario(int numLinha, HeaderCenarioModel headerCenarioModel, string modulo)
        {
            const string LINHA_TEMPLATE_HEADER = "B8:E8";
            Excel.Range sourceRange = templateWorksheet.Range[LINHA_TEMPLATE_HEADER];
            Excel.Range destinationRange = newWorksheet.Range[$"B{numLinha}"];
            sourceRange.Copy(destinationRange);

 
            newWorksheet.Range[$"B{numLinha}"].Value = $"Cen{numCenario++.ToString("000")}";
            newWorksheet.Range[$"C{numLinha}"].Value = $"[{headerCenarioModel.Sistema}] - {modulo}";
            newWorksheet.Range[$"D{numLinha}"].Value = $"{headerCenarioModel.Descricao}";
            newWorksheet.Range[$"E{numLinha}"].Value = $"{headerCenarioModel.Resultado}";
        }

        private void CriarPassoCenario(int numLinha, PassoModel passo)
        {
            const string LINHA_TEMPLATE_PASSO = "B9:E9";
            Excel.Range sourceRange = templateWorksheet.Range[LINHA_TEMPLATE_PASSO];

            Excel.Range destinationRange = newWorksheet.Range[$"B{numLinha}"];
            sourceRange.Copy(destinationRange);
            
            newWorksheet.Range[$"B{numLinha}"].Value = $"Passo {passo.NumeroPasso}";
            newWorksheet.Range[$"C{numLinha}"].Value = $"{passo.Tela}";
            newWorksheet.Range[$"D{numLinha}"].Value = $"{passo.Descricao}";
            newWorksheet.Range[$"E{numLinha}"].Value = $"{passo.Resultado}";
        }

        private void SalvarNovoPlano()
        {
            try
            {
                MessageBox.Show(newPath);
                newWorkbook.SaveAs(newPath + $"\\{planoTeste.HeaderPlanoTeste.CodigoDemanda} - Plano de Teste.xlsx", Excel.XlFileFormat.xlWorkbookDefault);
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

                MessageBox.Show("Células copiadas com sucesso para o novo arquivo Excel!");
            }
        }
    }
}

