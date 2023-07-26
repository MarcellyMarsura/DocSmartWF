﻿using DocSmart.Controllers;
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

namespace DocSmart.Views.Forms.ControleTestes
{
    public partial class ControleTestesForm : Form
    {
        public ControleTestesForm()
        {
            InitializeComponent();
        }

        private void btnPlanoTeste_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xlsx;";
            openFileDialog.Title = "Selecione o Plano de Testes";
            openFileDialog.ShowDialog();
            txtPathPlano.Text = openFileDialog.FileName;
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtPathPasta.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            var controleTestes = new ControleTestesController(openFileDialog.FileName);
            controleTestes.GeraControleTestes(folderBrowserDialog.SelectedPath);
        }

        private void ControleTestesForm_FormClosed(object sender, FormClosedEventArgs e)
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
