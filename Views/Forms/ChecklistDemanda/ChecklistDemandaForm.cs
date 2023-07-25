using DocSmart.Controllers;
using DocSmart.Models.ChecklistDemanda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSmart.Views.Forms.ChecklistDemanda
{
    public partial class ChecklistDemandaForm : Form
    {
        public ChecklistDemandaForm()
        {
            InitializeComponent();
            txtFormalizacao.Items.AddRange(MockDados.Formalizacoes().ToArray());
            txtPlanejamento.Items.AddRange(MockDados.Formalizacoes().ToArray());
            txtDesenho.Items.AddRange(MockDados.Formalizacoes().ToArray()); 
            txtConstrucao.Items.AddRange(MockDados.Formalizacoes().ToArray()); 
            txtTeste.Items.AddRange(MockDados.Formalizacoes().ToArray()); 
            txtSuporte.Items.AddRange(MockDados.Formalizacoes().ToArray());


        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            ChecklistDemandaModel checklistDemanda = ChecklistDemandaModel.Instance;
            checklistDemanda.Formalizacao = txtFormalizacao.CheckedItems.OfType<string>().ToList();
            checklistDemanda.Planejamento = txtPlanejamento.CheckedItems.OfType<string>().ToList();
            checklistDemanda.Desenho = txtDesenho.CheckedItems.OfType<string>().ToList();
            checklistDemanda.Construcao = txtConstrucao.CheckedItems.OfType<string>().ToList();
            checklistDemanda.Testes = txtTeste.CheckedItems.OfType<string>().ToList();
            checklistDemanda.Suporte = txtSuporte.CheckedItems.OfType<string>().ToList();

            ChecklistDemandaController checklist = new ChecklistDemandaController();
            checklist.CriarChecklist(folderBrowserDialog.SelectedPath);
        }
    }
}
