using DocSmart.Models.ChecklistDemanda;
using DocSmart.Models.PlanoDeTestes;
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
    public class ChecklistDemandaController
    {
        Excel.Application excelApp;
        Excel.Workbook templateWorkbook;
        Excel.Worksheet templateWorksheet;

        Excel.Workbook newWorkbook;
        Excel.Worksheet newWorksheet;

        ChecklistDemandaModel checklist;
        string newPath;

        public ChecklistDemandaController(string newPath)
        {
            var templatePath = "C:\\Projeto - Relatorio Estagio\\DocSmart - WF\\DocSmart\\Arquivos\\Templates\\ChecklistDemanda.xlsx";

            excelApp = new Excel.Application();
            templateWorkbook = excelApp.Workbooks.Open(templatePath);
            templateWorksheet = (Excel.Worksheet)templateWorkbook.ActiveSheet;

            newWorkbook = excelApp.Workbooks.Add();
            newWorksheet = (Excel.Worksheet)newWorkbook.ActiveSheet;

            checklist = ChecklistDemandaModel.Instance;

            this.newPath = newPath;
        }

        public void CriarChecklist()
        {
            try
            {
                int numLinha = 2;
                CriaWorkbook();
                Fases("Formalização", checklist.Formalizacao, ref numLinha);
                Fases("Planejamento", checklist.Planejamento, ref numLinha);
                Fases("Desenho", checklist.Desenho, ref numLinha);
                Fases("Construção", checklist.Construcao, ref numLinha);
                Fases("Testes", checklist.Testes, ref numLinha);
                Fases("Suporte", checklist.Suporte, ref numLinha);

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

        private void Fases(string nomeFase, List<string> checkedItems, ref int numLinha)
        {
            const string LINHA_TEMPLATE_HEADER = "A2:D2";
            const string LINHA_TEMPLATE = "A3:D3";
            Excel.Range sourceRange = templateWorksheet.Range[LINHA_TEMPLATE_HEADER];
            Excel.Range destinationRange = newWorksheet.Range[$"A{numLinha}"];
            sourceRange.Copy(destinationRange);
            newWorksheet.Range[$"A{numLinha++}"].Value = nomeFase;

            foreach (var item in checkedItems)
            {
                Excel.Range novoRange = templateWorksheet.Range[LINHA_TEMPLATE];
                Excel.Range destinationNovoRange = newWorksheet.Range[$"A{numLinha}"];
                novoRange.Copy(destinationNovoRange);

                newWorksheet.Range[$"A{numLinha++}"].Value = item;
            }

        }

        private void SalvarNovoPlano()
        {
            try
            {
                MessageBox.Show(newPath);
                newWorkbook.SaveAs(newPath + $"\\CheckList.xlsx", Excel.XlFileFormat.xlWorkbookDefault);
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
