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
    public partial class NovoPlanoForm : CustomForm<NovoPlanoForm>
    {
        PlanoDeTestesModel planoDeTestes = PlanoDeTestesModel.Instance;
        public NovoPlanoForm()
        {
            InitializeComponent();
            txtCliente.Items.AddRange(MockDados.Cliente().ToArray());

            Form = this;
        }

        private void btnCenarios_Click(object sender, EventArgs e)
        {
            try
            {
                HeaderPlanoTesteModel headerPlanoTeste = new HeaderPlanoTesteModel();
                headerPlanoTeste.Cliente = txtCliente.Text;
                headerPlanoTeste.Descricao = txtDescricao.Text;
                headerPlanoTeste.Titulo = txtTitulo.Text;
                headerPlanoTeste.CodigoDemanda = txtCodigoDemanda.Text;

                planoDeTestes.HeaderPlanoTeste = headerPlanoTeste;

                Utils.ProximaTela(this, new CenariosForm());
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void NovoPlanoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Utils.TelaAnterior(HomeForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.TelaAnterior(HomeForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }
    }
}
