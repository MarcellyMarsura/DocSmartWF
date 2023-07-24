using DocSmart.Models.DocumentacaoTestes;
using DocSmart.Models.PlanoDeTestes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;



namespace DocSmart.Controllers
{
    public class DocumentacaoTestes
    {
        //string currentDirectory;
        //string pathProjeto;
        //string templatePath;

        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        DocumentacaoTesteModel documentacaoTeste;
        int numCenario;
        string pathWord;
        string newPath;

        public DocumentacaoTestes(string pathExcel)
        {
            //currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.FullName;
            //pathProjeto = Directory.GetParent(Directory.GetParent(currentDirectory)?.FullName)?.FullName;
            //templatePath = $"{pathProjeto}\\DocSmart\\Arquivos\\Templates\\PlanoDeTestes.xlsx";


            excelApp = new Excel.Application();
            templateWorkbook = excelApp.Workbooks.Open(pathExcel);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;

            documentacaoTeste = DocumentacaoTesteModel.Instance;

        }

        public void LerExcel()
        {
            try
            {
                const string CELULA_TEMPLATE_CLIENTE = "C3";
                const string CELULA_TEMPLATE_DEMANDA = "C4";

                documentacaoTeste.Cliente = templateWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value;
                documentacaoTeste.Titulo = templateWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value;

                for (int numLinha = 8; ; numLinha++)
                {
                    if (templateWorksheet.Range[$"B{numLinha}"].Value == null
                        || templateWorksheet.Range[$"B{numLinha}"].Value == string.Empty)
                    {
                        break;
                    }

                    if (templateWorksheet.Range[$"B{numLinha}"].Value.Contains("Cen"))
                    {
                        DocumentacaoCenarioModel documentacaoCenarioModel = new DocumentacaoCenarioModel();

                        documentacaoCenarioModel.Cenario = templateWorksheet.Range[$"B{numLinha}"].Value;
                        documentacaoCenarioModel.Modulo = templateWorksheet.Range[$"C{numLinha}"].Value;
                        documentacaoCenarioModel.Descricao = templateWorksheet.Range[$"D{numLinha}"].Value;
                        documentacaoCenarioModel.Resultado = templateWorksheet.Range[$"E{numLinha}"].Value;

                        documentacaoTeste.Cenarios.Add(documentacaoCenarioModel);
                    }
                }
            }
            finally
            {
                // Fechar as pastas de trabalho e o aplicativo Excel
                templateWorkbook.Close();
                //newWorkbook.Close();
                excelApp.Quit();

                // Liberar recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorkbook);
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorksheet);
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            }
        }

    }
}
