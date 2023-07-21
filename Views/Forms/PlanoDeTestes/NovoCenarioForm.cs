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
    public partial class NovoCenarioForm : CustomForm
    {
        CenarioModel cenarioModel;
        PlanoDeTestesModel planoDeTestesModel = PlanoDeTestesModel.Instance;
        bool isEditMode = false;
        public NovoCenarioForm()
        {
            InitializeComponent();
            List<string> sistemas = new List<string>
            {
                "Sistema A",
                "Sistema B",
                "Sistema C",
            };

            txtSistema.Items.AddRange(sistemas.ToArray());


            List<string> modulos = new List<string>
            {
                "Modulo A",
                "Modulo B",
                "Modulo C",
            };

            txtModulos.Items.AddRange(sistemas.ToArray());

            cenarioModel = new CenarioModel();


            // Certifique-se que AutoGenerateColumns está definido como false
            dgPassos.AutoGenerateColumns = false;

            // Crie as colunas manualmente e especifique o nome da propriedade a ser exibida em cada coluna
            dgPassos.Columns.Add("NumeroPasso", "Passo");
            dgPassos.Columns.Add("Tela", "Tela");
            dgPassos.Columns.Add("Descricao", "Descrição");
            dgPassos.Columns.Add("Resultado", "Resultado");

            // Defina a propriedade que corresponde aos dados de cada coluna
            dgPassos.Columns["NumeroPasso"].DataPropertyName = "NumeroPasso";
            dgPassos.Columns["Tela"].DataPropertyName = "Tela";
            dgPassos.Columns["Descricao"].DataPropertyName = "Descricao";
            dgPassos.Columns["Resultado"].DataPropertyName = "Resultado";

            dgPassos.Columns["NumeroPasso"].Width = 80;
            dgPassos.Columns["Tela"].Width = 150;
            dgPassos.Columns["Descricao"].Width = 25;
            dgPassos.Columns["Resultado"].Width = 350;
        }

        private void btnFinalizarCenario_Click(object sender, EventArgs e)
        {
            
            HeaderCenarioModel headerCenarioModel = new HeaderCenarioModel();
            headerCenarioModel.Sistema = txtSistema.Text;
            headerCenarioModel.Resultado = txtResultado.Text;
            headerCenarioModel.Descricao = txtDescricao.Text;
            foreach (var item in txtModulos.Items)
            {
                headerCenarioModel.Modulos.Add(item.ToString());
            }

            cenarioModel.Header = headerCenarioModel;

            planoDeTestesModel.Cenarios.Add(cenarioModel);

            CenariosForm cenariosForm = new CenariosForm();
            cenariosForm.Show();

            this.Close();
        }

        private void btnAdicionarPasso_Click(object sender, EventArgs e)
        {
            int numeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
            if (cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1
                && isEditMode)
            {
                cenarioModel.Passos.Remove(cenarioModel.Passos.Find(x => x.NumeroPasso == numeroPasso));
            }
            else if ((cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1
                && !isEditMode))
            {
                MessageBox.Show("O numero do passo não pode ser igual");
                return;
            }
            
            PassoModel passoModel = new PassoModel();
            passoModel.NumeroPasso = Convert.ToInt32(txtNumeroPasso.Value);        
            passoModel.Resultado = txtResultadoPasso.Text;
            passoModel.Descricao = txtDescricaoPasso.Text;
            passoModel.NumeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
            passoModel.Tela = txtTela.Text;
            cenarioModel.Passos.Add(passoModel);
            cenarioModel.Passos.OrderBy(x => x.NumeroPasso).ToList();

            dgPassos.DataSource = null;
            dgPassos.DataSource = cenarioModel.Passos;
            isEditMode = false;
            
        }


        private void dgPassos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgPassos.Rows[e.RowIndex];

                txtNumeroPasso.Value = Convert.ToInt32(selectedRow.Cells[0].Value);
                txtTela.Text = selectedRow.Cells[1].Value.ToString();
                txtDescricaoPasso.Text = selectedRow.Cells[2].Value.ToString();
                txtResultadoPasso.Text = selectedRow.Cells[3].Value.ToString();
                isEditMode = true;
            }
        }

        private void btnExcluirPasso_Click(object sender, EventArgs e)
        {
            int numeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
            if (cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1)
            {
                cenarioModel.Passos.Remove(cenarioModel.Passos.Find(x => x.NumeroPasso == numeroPasso));
            }
            else
            {
                MessageBox.Show("Insira o numero do passo que deseja excluir");
                return;
            }
            cenarioModel.Passos.OrderBy(x => x.NumeroPasso).ToList();
            dgPassos.DataSource = null;
            dgPassos.DataSource = cenarioModel.Passos;
        }
    }
}
