using DocSmart.Controllers;
using DocSmart.Models.ChecklistDemanda;
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

namespace DocSmart
{
    public partial class Form1 : CustomForm<Form1>
    {
        public Form1()
        {
            InitializeComponent();
            Form = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var newPath = folderBrowserDialog1.SelectedPath;
            PlanoDeTestesModel planoDeTestesModel = PlanoDeTestesModel.Instance;
            HeaderPlanoTesteModel headerPlanoTesteModel = new HeaderPlanoTesteModel();
            headerPlanoTesteModel.Titulo = "Titulo";
            headerPlanoTesteModel.Cliente = "Cliente";
            headerPlanoTesteModel.Descricao = "Descricao";
            headerPlanoTesteModel.CodigoDemanda = "CodigoDemanda";



            CenarioModel cenarioModel = new CenarioModel();
            HeaderCenarioModel headerCenarioModel = new HeaderCenarioModel();
            headerCenarioModel.Sistema = "Sistema";
            headerCenarioModel.Resultado = "Resultado";
            headerCenarioModel.Descricao = "Descricao";
            headerCenarioModel.Modulos.Add("Modulo1");
            headerCenarioModel.Modulos.Add("Modulo2");

            PassoModel Passo1 = new PassoModel();

            Passo1.Resultado = 
@"Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado
Resultado";
            Passo1.Descricao = "Descricao";
            Passo1.NumeroPasso = 1;
            Passo1.Tela = "Tela";

            cenarioModel.Header = headerCenarioModel;
            cenarioModel.Passos.Add(Passo1);
            cenarioModel.Passos.Add(Passo1);
            cenarioModel.Passos.Add(Passo1);


            planoDeTestesModel.HeaderPlanoTeste = headerPlanoTesteModel;
            planoDeTestesModel.Cenarios.Add(cenarioModel);


            PlanoDeTestesController pt = new PlanoDeTestesController(newPath);
            pt.GerarPlanoTestes();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //DocumentacaoTestesController documentacaoTestes = new DocumentacaoTestesController(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
            //documentacaoTestes.LerExcel();

            ControleTestesController controleTestes = new ControleTestesController(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
            controleTestes.GeraControleTestes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            ChecklistDemandaModel checklistDemanda = ChecklistDemandaModel.Instance;
            checklistDemanda.Formalizacao = MockDados.Formalizacoes();
            checklistDemanda.Planejamento = MockDados.Formalizacoes();
            checklistDemanda.Desenho = MockDados.Formalizacoes();
            checklistDemanda.Construcao = MockDados.Formalizacoes();
            checklistDemanda.Testes = MockDados.Formalizacoes();
            checklistDemanda.Suporte = MockDados.Formalizacoes();

            ChecklistDemandaController checklist = new ChecklistDemandaController(folderBrowserDialog1.SelectedPath);
            checklist.CriarChecklist();
        }
    }
}
