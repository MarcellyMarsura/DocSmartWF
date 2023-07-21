using DocSmart.Models.Admin;
using DocSmart.Views.Forms.PlanoDeTestes;
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
    public partial class HomeForm : CustomForm
    {
        public HomeForm()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnPlanoDeTestes_Click(object sender, EventArgs e)
        {
            Utils.ProximaTela(this, new NovoPlanoForm());
        }

        private void btnDocumentacaoDeTeste_Click(object sender, EventArgs e)
        {
            //TODO: Adicionar fluxo de tela DocumentacaoDeTeste
        }

        private void btnControleTestes_Click(object sender, EventArgs e)
        {
            //TODO: Adicionar fluxo de tela ControleTestes
        }

        private void btnChecklistDemanda_Click(object sender, EventArgs e)
        {
            //TODO: Adicionar fluxo de tela ChecklistDemanda
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            usuarioModel.Usuario = txtUsuario.Text;
            usuarioModel.Senha = txtSenha.Text;

            //TODO: Método de validação para login de usuario
        }
    }
}
