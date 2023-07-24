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
    public partial class NovoCenarioForm : CustomForm<NovoCenarioForm>
    {
        CenarioModel cenarioModel;
        PlanoDeTestesModel planoDeTestesModel = PlanoDeTestesModel.Instance;
        bool isEditMode = false;

        public NovoCenarioForm()
        {
            try
            {
                InitializeComponent();

                txtSistema.Items.AddRange(MockDados.Sistema().ToArray());
                txtModulos.Items.AddRange(MockDados.Modulo().ToArray());
                CriarDataGridView();

                cenarioModel = new CenarioModel();

                Form = this;
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }
        private void CriarDataGridView()
        {
            dgPassos.AutoGenerateColumns = false;

            dgPassos.Columns.Add("NumeroPasso", "Passo");
            dgPassos.Columns.Add("Tela", "Tela");
            dgPassos.Columns.Add("Descricao", "Descrição");
            dgPassos.Columns.Add("Resultado", "Resultado");

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
            try
            {
                HeaderCenarioModel headerCenarioModel = new HeaderCenarioModel();
                headerCenarioModel.Sistema = txtSistema.Text;
                headerCenarioModel.Resultado = txtResultado.Text;
                headerCenarioModel.Descricao = txtDescricao.Text;

                foreach (var item in txtModulos.CheckedItems)
                {
                    headerCenarioModel.Modulos.Add(item.ToString());
                }

                cenarioModel.Header = headerCenarioModel;

                planoDeTestesModel.Cenarios.Add(cenarioModel);

                Utils.TelaAnterior(CenariosForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnAdicionarPasso_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPasso = Convert.ToInt32(txtNumeroPasso.Value);

                if (ValidaNumeroPasso(numeroPasso))
                {
                    PassoModel passoModel = new PassoModel();
                    passoModel.NumeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
                    passoModel.Resultado = txtResultadoPasso.Text;
                    passoModel.Descricao = txtDescricaoPasso.Text;
                    passoModel.NumeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
                    passoModel.Tela = txtTela.Text;
                    cenarioModel.Passos.Add(passoModel);
                    cenarioModel.Passos = cenarioModel.Passos.OrderBy(x => x.NumeroPasso).ToList();

                    dgPassos.DataSource = null;
                    dgPassos.DataSource = cenarioModel.Passos;
                    isEditMode = false;
                }

            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
            
        }
        private bool ValidaNumeroPasso(int numeroPasso)
        {
            if (cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1
                && isEditMode)
            {
                cenarioModel.Passos.Remove(cenarioModel.Passos.Find(x => x.NumeroPasso == numeroPasso));
            }
            else if ((cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1
                && !isEditMode))
            {
                MessageBox.Show("O numero do passo não pode ser igual");
                return false;
            }
            return true;
        }

        private void dgPassos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnExcluirPasso_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPasso = Convert.ToInt32(txtNumeroPasso.Value);
                if (cenarioModel.Passos.FindIndex(x => x.NumeroPasso == numeroPasso) != -1)
                {
                    cenarioModel.Passos.Remove(cenarioModel.Passos.Find(x => x.NumeroPasso == numeroPasso));
                    cenarioModel.Passos = cenarioModel.Passos.OrderBy(x => x.NumeroPasso).ToList();

                }
                else
                {
                    MessageBox.Show("Insira o numero do passo que deseja excluir");
                    return;
                }
                dgPassos.DataSource = null;
                dgPassos.DataSource = cenarioModel.Passos;
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
                Utils.TelaAnterior(CenariosForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void NovoCenarioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Utils.TelaAnterior(CenariosForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }
    }
}
