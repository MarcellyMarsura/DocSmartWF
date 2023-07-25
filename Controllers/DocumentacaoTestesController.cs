using DocSmart.Models.DocumentacaoTestes;
using DocSmart.Models.PlanoDeTestes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace DocSmart.Controllers
{
    public class DocumentacaoTestesController
    {
        //string currentDirectory;
        //string pathProjeto;
        //string templatePath;

        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;
        
        Word.Application wordApp;
        Word.Document doc;

        string pathWord;

        DocumentacaoTesteModel documentacaoTeste;
  
        public DocumentacaoTestesController(string pathExcel, string pathWord)
        {
            //currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.FullName;
            //pathProjeto = Directory.GetParent(Directory.GetParent(currentDirectory)?.FullName)?.FullName;
            //templatePath = $"{pathProjeto}\\DocSmart\\Arquivos\\Templates\\PlanoDeTestes.xlsx";


            excelApp = new Excel.Application();
            templateWorkbook = excelApp.Workbooks.Open(pathExcel);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;

            

            documentacaoTeste = DocumentacaoTesteModel.Instance;
            this.pathWord = pathWord;
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
                GeraDocumentacao();
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

        private void GeraDocumentacao()
        {
            foreach (var cenario in documentacaoTeste.Cenarios)
            {
                CriaWordPreenchido(cenario);
            }
        }

        private void CriaWordPreenchido(DocumentacaoCenarioModel cenario)
        {
            
            try
            {
                wordApp = new Word.Application();
                string templatePath = "C:\\Projeto - Relatorio Estagio\\DocSmart - WF\\DocSmart\\Arquivos\\Templates\\DocumentacaoTestes.docx";
                doc = wordApp.Documents.Add(templatePath);

                object replaceAll = Word.WdReplace.wdReplaceAll;

                doc.Content.Find.Execute(FindText: "##CLIENTE##", ReplaceWith: documentacaoTeste.Cliente, Replace: replaceAll); ;
                doc.Content.Find.Execute(FindText: "##TITULO##", ReplaceWith: documentacaoTeste.Titulo, Replace: replaceAll);
                
                doc.Content.Find.Execute(FindText: "##MODULO##", ReplaceWith: cenario.Modulo, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##CENARIO##", ReplaceWith: cenario.Cenario, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##DESCRICAO##", ReplaceWith: cenario.Descricao, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##RESULTADO##", ReplaceWith: cenario.Resultado, Replace: replaceAll);

                doc.SaveAs2(pathWord + $"\\{cenario.Modulo} - {cenario.Cenario}.docx");
            }
            finally
            {
                doc.Close();
                wordApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                doc = null;
                wordApp = null;
                GC.Collect();
            }
        }
    }
}
