using System;
using System.Windows.Forms;
using DocSmart.Models.PlanoDeTestes;
using Excel = Microsoft.Office.Interop.Excel;

namespace DocSmart.Controllers
{
    internal class PlanoDeTestesController
    {

        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        PlanoDeTestesModel planoTeste;
        int numCenario;

        public PlanoDeTestesController()
        {
            planoTeste = PlanoDeTestesModel.Instance;
            numCenario = 1;

            InicializarArquivos();
        }

        private void InicializarArquivos()
        {
            excelApp = new Excel.Application();
            AbrirExcelTemplate(ArquivoHelper.DiretorioTemplatePlanoDeTestes());
            CriarNovoExcel();
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

        public void GerarPlanoTestes(string diretorioNovoArquivo)
        {
            try
            {
                int numLinha = 8;

                PreencherDescricaoDocumento();

                foreach (var cenario in planoTeste.Cenarios)
                    PreencherCenario(cenario,ref numLinha);

                SalvarNovoPlano(diretorioNovoArquivo);
            }
            finally
            {
                FecharArquivos();
                MessageBox.Show($"Plano de testes foi gerado no diretório {diretorioNovoArquivo}",
                                "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PreencherCenario(CenarioModel cenario, ref int numLinha)
        {
            foreach (var modulo in cenario.Header.Modulos)
            {
                CriarTituloCenario(ref numLinha, cenario.Header, modulo);
                foreach (var passo in cenario.Passos)
                {
                    CriarPassoCenario(ref numLinha, passo);
                }
            }
        }

        private void PreencherDescricaoDocumento()
        {
            const string CELULA_TEMPLATE_CLIENTE = "C3";
            const string CELULA_TEMPLATE_DEMANDA = "C4";
            const string CELULA_TEMPLATE_DESCRICAO = "C5";

            newWorksheet.Range[CELULA_TEMPLATE_CLIENTE].Value = planoTeste.HeaderPlanoTeste.Cliente;

            newWorksheet.Range[CELULA_TEMPLATE_DEMANDA].Value =
                $"{planoTeste.HeaderPlanoTeste.CodigoDemanda} - {planoTeste.HeaderPlanoTeste.Titulo}";

            newWorksheet.Range[CELULA_TEMPLATE_DESCRICAO].Value = planoTeste.HeaderPlanoTeste.Descricao;

        }

        private void CopiarCelulasTemplate(string linhaTemplate, string linhaNovoExcel)
        {
            Excel.Range sourceRange = templateWorksheet.Range[linhaTemplate];
            Excel.Range destinationRange = newWorksheet.Range[linhaNovoExcel];
            sourceRange.Copy(destinationRange);
        }

        private void CriarTituloCenario(ref int numLinha, HeaderCenarioModel headerCenarioModel, string modulo)
        {
            CopiarCelulasTemplate("B8:E8", $"B{numLinha}");

            newWorksheet.Range[$"B{numLinha}"].Value = $"Cen{numCenario++.ToString("000")}";
            newWorksheet.Range[$"C{numLinha}"].Value = $"[{headerCenarioModel.Sistema}] - {modulo}";
            newWorksheet.Range[$"D{numLinha}"].Value = $"{headerCenarioModel.Descricao}";
            newWorksheet.Range[$"E{numLinha}"].Value = $"{headerCenarioModel.Resultado}";
            
            numLinha++;
        }

        private void CriarPassoCenario(ref int numLinha, PassoModel passo)
        {
            CopiarCelulasTemplate("B9:E9", $"B{numLinha}");
            
            newWorksheet.Range[$"B{numLinha}"].Value = $"Passo {passo.NumeroPasso}";
            newWorksheet.Range[$"C{numLinha}"].Value = $"{passo.Tela}";
            newWorksheet.Range[$"D{numLinha}"].Value = $"{passo.Descricao}";
            newWorksheet.Range[$"E{numLinha}"].Value = $"{passo.Resultado}";

            numLinha++;
        }

        private void SalvarNovoPlano(string diretorioNovoArquivo)
        {
            string nomeArquivo = $"{planoTeste.HeaderPlanoTeste.CodigoDemanda} - Plano de Teste.xlsx";
            newWorkbook.SaveAs($"{diretorioNovoArquivo}\\{nomeArquivo}", Excel.XlFileFormat.xlWorkbookDefault);

        }

        private void FecharArquivos()
        {
            templateWorkbook.Close();
            newWorkbook.Close();
            excelApp.Quit();

            ArquivoHelper.LiberarRecursos(templateWorksheet);
            ArquivoHelper.LiberarRecursos(templateWorkbook);
            ArquivoHelper.LiberarRecursos(newWorksheet);
            ArquivoHelper.LiberarRecursos(newWorkbook);
            ArquivoHelper.LiberarRecursos(excelApp);
        }
    }
}

