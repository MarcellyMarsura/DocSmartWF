using DocSmart.Models.PlanoDeTestes;
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

namespace DocSmart.Views.Forms.PlanoDeTestes
{
    public partial class NovoPlanoForm : CustomForm
    {
        PlanoDeTestesModel planoDeTestes = PlanoDeTestesModel.Instance;
        public NovoPlanoForm()
        {
            InitializeComponent();
            txtCliente.Items.AddRange(MockDados.Cliente().ToArray());
        }

        private void btnCenarios_Click(object sender, EventArgs e)
        {
            HeaderPlanoTesteModel headerPlanoTeste = new HeaderPlanoTesteModel();
            headerPlanoTeste.Cliente = txtCliente.Text;
            headerPlanoTeste.Descricao = txtDescricao.Text;
            headerPlanoTeste.Titulo = txtTitulo.Text;
            headerPlanoTeste.CodigoDemanda = txtCodigoDemanda.Text;

            planoDeTestes.HeaderPlanoTeste = headerPlanoTeste;

            Utils.ProximaTela(this, new CenariosForm());
        }

        private void NovoPlanoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.TelaAnterior(new HomeForm(), this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utils.TelaAnterior(new HomeForm(), this);
        }
    }
}
