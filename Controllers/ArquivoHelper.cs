using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Controllers
{
    public static class ArquivoHelper
    {
        private static readonly string diretorioProjeto = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory())?.FullName)?.FullName;

        public static void MessageBoxSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LiberarRecursos(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Erro ao liberar objeto COM: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }


        public static string DiretorioTemplatePlanoDeTestes()
        {
            string diretorioTemplate = $"{diretorioProjeto}\\Arquivos\\Templates\\PlanoDeTestes.xlsx";
            return diretorioTemplate;
        }

        public static string DiretorioTemplateDocumentacaoTestes()
        {
            string diretorioTemplate = $"{diretorioProjeto}\\Arquivos\\Templates\\DocumentacaoTestes.docx";
            return diretorioTemplate;
        }

        public static string DiretorioTemplateControleTestes()
        {
            string diretorioTemplate = $"{diretorioProjeto}\\Arquivos\\Templates\\ControleTestes.xlsx";
            return diretorioTemplate;
        }

        public static string DiretorioTemplateChecklistDemanda()
        {
            string diretorioTemplate = $"{diretorioProjeto}\\Arquivos\\Templates\\ChecklistDemanda.xlsx";
            return diretorioTemplate;
        }
    }
}
