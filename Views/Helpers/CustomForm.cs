using DocSmart.Views.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Views.Helpers
{
    public class CustomForm<T> : Form
    {
        public static T Form;
        public static T Instance { get => Form; }

        public CustomForm()
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Font = new Font("Segoe UI", 12, FontStyle.Regular);
            Text = "DocSmart";
            BackColor = Color.LightGray;
        }
    }
}
