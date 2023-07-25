using DocSmart.Models.DocumentacaoTestes;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace DocSmart.Controllers
{
    public class DocumentacaoTestesController
    {
        Excel.Application excelApp;
        Excel.Workbook planoDeTestesWorkbook;
        Excel.Worksheet planoDeTestesWorksheet;
        
        Word.Application wordApp;
        Word.Document doc;

        DocumentacaoTesteModel documentacaoTeste;
  
        public DocumentacaoTestesController(string diretorioPlanoDeTestes)
        {
            InicializarArquivos(diretorioPlanoDeTestes);
            
            documentacaoTeste = DocumentacaoTesteModel.Instance;
        }

        private void InicializarArquivos(string diretorioPlanoDeTestes)
        {
            excelApp = new Excel.Application();
            AbrirExcelPlanoDeTestes(diretorioPlanoDeTestes);
        }

        private void AbrirExcelPlanoDeTestes(string diretorioTemplate)
        {
            planoDeTestesWorkbook = excelApp.Workbooks.Open(diretorioTemplate);
            planoDeTestesWorksheet = (Excel.Worksheet)planoDeTestesWorkbook.ActiveSheet;
        }


        public void GerarDocumentosTestes(string diretorioNovoArquivo)
        {
            try
            {
                LerExcel();
                foreach (var cenario in documentacaoTeste.Cenarios)
                {
                    CriarWord();
                    PreencherWord(cenario, diretorioNovoArquivo);
                }
            }
            finally
            {
                FecharExcel();
                ArquivoHelper.MessageBoxSucesso($"Os arquivos foram gerados no diretório {diretorioNovoArquivo}");
            }

        }

        private void LerExcel()
        {
            const string CELULA_TEMPLATE_CLIENTE = "C3";
            const string CELULA_TEMPLATE_DEMANDA = "C4";

            documentacaoTeste.Cliente = planoDeTestesWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value;
            documentacaoTeste.Titulo = planoDeTestesWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value;

            int numLinha = 8;
            while(planoDeTestesWorksheet.Range[$"B{numLinha}"].Value != null)
            {

                if (planoDeTestesWorksheet.Range[$"B{numLinha}"].Value.Contains("Cen"))
                {
                    DocumentacaoCenarioModel documentacaoCenarioModel = new DocumentacaoCenarioModel();

                    documentacaoCenarioModel.Cenario = planoDeTestesWorksheet.Range[$"B{numLinha}"].Value;
                    documentacaoCenarioModel.Modulo = planoDeTestesWorksheet.Range[$"C{numLinha}"].Value;
                    documentacaoCenarioModel.Descricao = planoDeTestesWorksheet.Range[$"D{numLinha}"].Value;
                    documentacaoCenarioModel.Resultado = planoDeTestesWorksheet.Range[$"E{numLinha}"].Value;

                    documentacaoTeste.Cenarios.Add(documentacaoCenarioModel);
                }
                numLinha++;
            }
            
        }


        private void PreencherWord(DocumentacaoCenarioModel cenario, string diretorioNovoArquivo)
        {
            try
            {
                object replaceAll = Word.WdReplace.wdReplaceAll;

                doc.Content.Find.Execute(FindText: "##CLIENTE##", ReplaceWith: documentacaoTeste.Cliente, Replace: replaceAll); ;
                doc.Content.Find.Execute(FindText: "##TITULO##", ReplaceWith: documentacaoTeste.Titulo, Replace: replaceAll);
                
                doc.Content.Find.Execute(FindText: "##MODULO##", ReplaceWith: cenario.Modulo, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##CENARIO##", ReplaceWith: cenario.Cenario, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##DESCRICAO##", ReplaceWith: cenario.Descricao, Replace: replaceAll);
                doc.Content.Find.Execute(FindText: "##RESULTADO##", ReplaceWith: cenario.Resultado, Replace: replaceAll);

                SalvarWord(cenario, diretorioNovoArquivo);
            }
            finally
            {
                FecharWord();
            }
        }
        private void FecharExcel()
        {
            planoDeTestesWorkbook.Close();
            excelApp.Quit();

            ArquivoHelper.LiberarRecursos(planoDeTestesWorksheet);
            ArquivoHelper.LiberarRecursos(planoDeTestesWorkbook);
            ArquivoHelper.LiberarRecursos(excelApp);
        }

        private void CriarWord()
        {
            wordApp = new Word.Application();
            doc = wordApp.Documents.Add(ArquivoHelper.DiretorioTemplateDocumentacaoTestes());
        }

        private void SalvarWord(DocumentacaoCenarioModel cenario, string diretorioNovoArquivo)
        {
            string nomeArquivo = $"{cenario.Modulo} - {cenario.Cenario}.docx";
            doc.SaveAs2($"{diretorioNovoArquivo}\\{nomeArquivo}");
        }

        private void FecharWord()
        {
            doc.Close();
            wordApp.Quit();

            ArquivoHelper.LiberarRecursos(doc);
            ArquivoHelper.LiberarRecursos(wordApp);
        }
    }
}
