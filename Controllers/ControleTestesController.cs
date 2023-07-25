using DocSmart.Models.DocumentacaoTestes;
using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace DocSmart.Controllers
{
    public class ControleTestesController
    {
        Excel.Application excelApp;
        Excel.Workbook planoDeTestesWorkbook;
        Excel.Worksheet planoDeTestesWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        DocumentacaoTesteModel documentacaoTeste;

        public ControleTestesController(string diretorioPlanoTeste)
        {            
            InicializarArquivos(diretorioPlanoTeste);
            documentacaoTeste = DocumentacaoTesteModel.Instance;
        }

        private void InicializarArquivos(string diretorioPlanoTeste)
        {
            excelApp = new Excel.Application();
            AbrirExcelPlanoDeTestes(diretorioPlanoTeste);
            AbrirExcelTemplate(ArquivoHelper.DiretorioTemplateControleTestes());
            CriarNovoExcel();
        }
        private void AbrirExcelPlanoDeTestes(string diretorioPlanoTeste)
        {
            planoDeTestesWorkbook = excelApp.Workbooks.Open(diretorioPlanoTeste);
            planoDeTestesWorksheet = (Excel.Worksheet)planoDeTestesWorkbook.ActiveSheet;
        }

        private void AbrirExcelTemplate(string diretorioTemplate)
        {
            templateWorkbook = excelApp.Workbooks.Open(diretorioTemplate);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;
        }

        private void CriarNovoExcel()
        {
            newWorkbook = excelApp.Workbooks.Add();
            newWorksheet = (Excel.Worksheet)newWorkbook.ActiveSheet;
            templateWorksheet.Cells.Copy(Type.Missing);
            newWorksheet.Cells.PasteSpecial(Excel.XlPasteType.xlPasteAll);
        }


        public void GeraControleTestes(string diretorioNovoArquivo)
        {
            try
            {
                LerExcel();
                PreencheExcel();
                SalvarNovo(diretorioNovoArquivo);
            }
            finally
            {
                FecharArquivos();
            }
        }

        private void LerExcel()
        {
            const string CELULA_TEMPLATE_CLIENTE = "C3";
            const string CELULA_TEMPLATE_DEMANDA = "C4";

            documentacaoTeste.Cliente = planoDeTestesWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value;
            documentacaoTeste.Titulo = planoDeTestesWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value;

            int numLinha = 8;
            while (planoDeTestesWorksheet.Range[$"B{numLinha}"].Value != null)
            {

                if (planoDeTestesWorksheet.Range[$"B{numLinha}"].Value.Contains("Cen"))
                {
                    DocumentacaoCenarioModel documentacaoCenarioModel = new DocumentacaoCenarioModel();

                    documentacaoCenarioModel.Cenario = planoDeTestesWorksheet.Range[$"B{numLinha}"].Value;
                    documentacaoCenarioModel.Modulo = planoDeTestesWorksheet.Range[$"C{numLinha}"].Value;

                    documentacaoTeste.Cenarios.Add(documentacaoCenarioModel);
                }
                numLinha++;
            }
        }

        private void PreencheExcel()
        {
            int numLinha = 2;
            foreach (var cenario in documentacaoTeste.Cenarios)
            {
                CopiarCelulasTemplate("A2:H2", $"A{numLinha}");

                newWorksheet.Range[$"A{numLinha}"].Value = $"{cenario.Modulo}";
                newWorksheet.Range[$"B{numLinha}"].Value = $"{cenario.Cenario}";
                numLinha++;
            }

        }

        private void CopiarCelulasTemplate(string linhaTemplate, string linhaNovoExcel)
        {
            Excel.Range sourceRange = templateWorksheet.Range[linhaTemplate];
            Excel.Range destinationRange = newWorksheet.Range[linhaNovoExcel];
            sourceRange.Copy(destinationRange);
        }


        private void SalvarNovo(string diretorioNovoArquivo)
        {
            string nomeArquivo = $"{documentacaoTeste.Titulo} - Controle de Teste.xlsx";
            newWorkbook.SaveAs($"{diretorioNovoArquivo}\\{nomeArquivo}", Excel.XlFileFormat.xlWorkbookDefault);
        }

        private void FecharArquivos()
        {
            planoDeTestesWorkbook.Close();
            templateWorkbook.Close();
            newWorkbook.Close();
            excelApp.Quit();

            ArquivoHelper.LiberarRecursos(planoDeTestesWorksheet);
            ArquivoHelper.LiberarRecursos(planoDeTestesWorkbook);
            ArquivoHelper.LiberarRecursos(templateWorksheet);
            ArquivoHelper.LiberarRecursos(templateWorkbook);
            ArquivoHelper.LiberarRecursos(newWorksheet);
            ArquivoHelper.LiberarRecursos(newWorkbook);
            ArquivoHelper.LiberarRecursos(excelApp);
        }
    }
}
