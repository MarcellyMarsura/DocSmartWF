using DocSmart.Controllers;
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
    public partial class CenariosForm : CustomForm<CenariosForm>
    {
        PlanoDeTestesModel planoDeTestes = PlanoDeTestesModel.Instance;
        public CenariosForm()
        {
            try
            {
                InitializeComponent();
                CriarDataGridView();

                Form = this;
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }

        }
        private void CriarDataGridView()
        {
            dgCenarios.Columns.Add("Sistema", "Sistema");
            dgCenarios.Columns.Add("Modulos", "Módulos");
            dgCenarios.Columns.Add("Resultado", "Resultado");
            dgCenarios.Columns.Add("Descricao", "Descrição");

        }

        private void btnNovoCenario_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.ProximaTela(this, new NovoCenarioForm());
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
                Utils.TelaAnterior(NovoPlanoForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void btnFinalizarPlano_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Adicionar OpenFolderDialog para inserir newPath

                folderBrowserDialog1.ShowDialog();
                string newPath = folderBrowserDialog1.SelectedPath;
                PlanoDeTestesController planoDeTestesController = new PlanoDeTestesController(newPath);
                planoDeTestesController.GerarPlanoTestes();
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void CenariosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Utils.TelaAnterior(NovoPlanoForm.Instance, this);
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }

        private void CenariosForm_Activated(object sender, EventArgs e)
        {
            try
            {
                dgCenarios.Rows.Clear();

                foreach (CenarioModel cenario in planoDeTestes.Cenarios)
                {
                    int rowIndex = dgCenarios.Rows.Add();

                    dgCenarios.Rows[rowIndex].Cells["Sistema"].Value = cenario.Header.Sistema;
                    dgCenarios.Rows[rowIndex].Cells["Modulos"].Value = string.Join(Environment.NewLine, cenario.Header.Modulos);
                    dgCenarios.Rows[rowIndex].Cells["Resultado"].Value = cenario.Header.Resultado;
                    dgCenarios.Rows[rowIndex].Cells["Descricao"].Value = cenario.Header.Descricao;
                }
            }
            catch (Exception ex)
            {
                Utils.ExibeMensagemErro(ex.Message);
            }
        }
    }
}
