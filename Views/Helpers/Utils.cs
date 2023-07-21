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
            formFilho.Close();
            formPai.Show();
        }
    }
}
