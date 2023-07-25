using DocSmart.Models.ChecklistDemanda;
using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;


namespace DocSmart.Controllers
{
    public class ChecklistDemandaController
    {
        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        ChecklistDemandaModel checklist;

        public ChecklistDemandaController()
        {
            InicializarArquivos();
            checklist = ChecklistDemandaModel.Instance;
        }

        private void InicializarArquivos()
        {
            excelApp = new Excel.Application();
            AbrirExcelTemplate(ArquivoHelper.DiretorioTemplateChecklistDemanda());
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

        public void CriarChecklist(string diretorioNovoArquivo)
        {
            try
            {
                int numLinha = 2;

                PreencherExcel("Formalização", checklist.Formalizacao, ref numLinha);
                PreencherExcel("Planejamento", checklist.Planejamento, ref numLinha);
                PreencherExcel("Desenho", checklist.Desenho, ref numLinha);
                PreencherExcel("Construção", checklist.Construcao, ref numLinha);
                PreencherExcel("Testes", checklist.Testes, ref numLinha);
                PreencherExcel("Suporte", checklist.Suporte, ref numLinha);
                SalvarNovoArquivo(diretorioNovoArquivo);
            }
            finally
            {
                FecharArquivos();
                ArquivoHelper.MessageBoxSucesso($"Checklist da demanda foi gerado no diretório {diretorioNovoArquivo}");
            }
        }

        private void PreencherExcel(string nomeFase, List<string> checkedItems, ref int numLinha)
        {
            CopiarCelulasTemplate("A2:D2", $"A{numLinha}");
            newWorksheet.Range[$"A{numLinha++}"].Value = nomeFase;

            foreach (var item in checkedItems)
            {
                CopiarCelulasTemplate("A3:D3", $"A{numLinha}");
                newWorksheet.Range[$"A{numLinha++}"].Value = item;
            }

        }

        private void CopiarCelulasTemplate(string linhaTemplate, string linhaNovoExcel)
        {
            Excel.Range sourceRange = templateWorksheet.Range[linhaTemplate];
            Excel.Range destinationRange = newWorksheet.Range[linhaNovoExcel];
            sourceRange.Copy(destinationRange);
        }

        private void SalvarNovoArquivo(string diretorioNovoArquivo)
        {
            string nomeArquivo = "CheckList.xlsx";
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
