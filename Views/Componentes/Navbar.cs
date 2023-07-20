using DocSmart.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Views.Componentes
{
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

        private void lblSobre_Click(object sender, EventArgs e)
        {
            SobreForm sobreForm = new SobreForm();
            sobreForm.ShowDialog();
        }
    }
}
