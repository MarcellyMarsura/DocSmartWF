using DocSmart.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Views.Helpers
{
    public static class Utils
    {
        public static void ProximaTela(Form formPai, Form formFilho)
        {
            formPai.Hide();
            formFilho.ShowDialog();
        }

        public static void TelaAnterior(Form formPai, Form formFilho)
        {
            if(formPai == null)
            {
                MessageBox.Show("Erro ao voltar a tela");
                Application.Exit();
                return;
            }
            formFilho.Close();
            formPai.Show();
        }

        public static void ExibeMensagemErro(string erro)
        {
            MessageBox.Show(erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
