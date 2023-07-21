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
    public partial class CenariosForm : CustomForm
    {
        PlanoDeTestesModel planoDeTestes = PlanoDeTestesModel.Instance;
        public CenariosForm()
        {
            InitializeComponent();
            dgCenarios.Columns.Add("Sistema", "Sistema");
            dgCenarios.Columns.Add("Modulos", "Módulos");
            dgCenarios.Columns.Add("Resultado", "Resultado");
            dgCenarios.Columns.Add("Descricao", "Descrição");

            dgCenarios.Rows.Clear();

            // Percorra cada cenário e adicione uma linha para cada um no DataGridView
            foreach (CenarioModel cenario in planoDeTestes.Cenarios)
            {
                // Adicione uma nova linha no DataGridView
                int rowIndex = dgCenarios.Rows.Add();

                // Acesse as propriedades do HeaderCenarioModel e preencha as colunas correspondentes
                dgCenarios.Rows[rowIndex].Cells["Sistema"].Value = cenario.Header.Sistema;
                dgCenarios.Rows[rowIndex].Cells["Modulos"].Value = string.Join(Environment.NewLine, cenario.Header.Modulos);
                dgCenarios.Rows[rowIndex].Cells["Resultado"].Value = cenario.Header.Resultado;
                dgCenarios.Rows[rowIndex].Cells["Descricao"].Value = cenario.Header.Descricao;
            }
        }

        private void btnNovoCenario_Click(object sender, EventArgs e)
        {
            NovoCenarioForm novoCenarioForm = new NovoCenarioForm();
            this.Hide();
            novoCenarioForm.ShowDialog();
        }
    }
}
