using DocSmart.Controllers;
using DocSmart.Views.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Views.Forms.DocumentacaoTestes
{
    public partial class DocumentacaoTestesForm : Form
    {
        public DocumentacaoTestesForm()
        {
            InitializeComponent();
        }

        private void btnPlanoTeste_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xlsx;";
            openFileDialog.Title = "Selecione o Plano de Testes";
            openFileDialog.ShowDialog();
            txtPathPlano.Text = openFileDialog.FileName;
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtPathPasta.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            var documentacaoTestes = new DocumentacaoTestesController(openFileDialog.FileName);
            documentacaoTestes.GerarDocumentosTestes(folderBrowserDialog.SelectedPath);
        }

 
    }
}
