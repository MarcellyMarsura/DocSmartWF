using DocSmart.Models.Admin;
using DocSmart.Models.DocumentacaoTestes;
using DocSmart.Models.PlanoDeTestes;
using DocSmart.Views.Forms.PlanoDeTestes;
using DocSmart.Views.Forms.DocumentacaoTestes;
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

namespace DocSmart.Views.Forms
{
    public partial class HomeForm : CustomForm<HomeForm>
    {
        public HomeForm()
        {
            try
            {
                InitializeComponent();
                txtSenha.UseSystemPasswordChar = true;

                Form = this;
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
            
        }

        private void btnPlanoDeTestes_Click(object sender, EventArgs e)
        {
            try
            {
                PlanoDeTestesModel planoDeTestes = PlanoDeTestesModel.Clear;
                Utils.ProximaTela(this, new NovoPlanoForm());
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnDocumentacaoDeTeste_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentacaoTesteModel documentacaoTesteModel = DocumentacaoTesteModel.Clear;
                Utils.ProximaTela(this, new DocumentacaoTestesForm());
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnControleTestes_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
                //TODO: Adicionar fluxo de tela ControleTestes
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnChecklistDemanda_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
                //TODO: Adicionar fluxo de tela ChecklistDemanda
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.Usuario = txtUsuario.Text;
                usuarioModel.Senha = txtSenha.Text;

                throw new NotImplementedException();
                //TODO: Método de validação para login de usuario
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }
    }
}
