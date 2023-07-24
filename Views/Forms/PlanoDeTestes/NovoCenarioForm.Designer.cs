namespace DocSmart.Views.Forms.PlanoDeTestes
{
    partial class NovoCenarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirPasso = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroPasso = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarCenario = new System.Windows.Forms.Button();
            this.dgPassos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarPasso = new System.Windows.Forms.Button();
            this.txtResultadoPasso = new System.Windows.Forms.RichTextBox();
            this.txtDescricaoPasso = new System.Windows.Forms.RichTextBox();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSistema = new System.Windows.Forms.ComboBox();
            this.txtModulos = new System.Windows.Forms.CheckedListBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnExcluirPasso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNumeroPasso);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnFinalizarCenario);
            this.panel1.Controls.Add(this.dgPassos);
            this.panel1.Controls.Add(this.btnAdicionarPasso);
            this.panel1.Controls.Add(this.txtResultadoPasso);
            this.panel1.Controls.Add(this.txtDescricaoPasso);
            this.panel1.Controls.Add(this.txtTela);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSistema);
            this.panel1.Controls.Add(this.txtModulos);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 1604);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirPasso
            // 
            this.btnExcluirPasso.Location = new System.Drawing.Point(432, 1050);
            this.btnExcluirPasso.Name = "btnExcluirPasso";
            this.btnExcluirPasso.Size = new System.Drawing.Size(147, 48);
            this.btnExcluirPasso.TabIndex = 37;
            this.btnExcluirPasso.Text = "Excluir Passo";
            this.btnExcluirPasso.UseVisualStyleBackColor = true;
            this.btnExcluirPasso.Click += new System.EventHandler(this.btnExcluirPasso_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tela:";
            // 
            // txtNumeroPasso
            // 
            this.txtNumeroPasso.Location = new System.Drawing.Point(40, 522);
            this.txtNumeroPasso.Name = "txtNumeroPasso";
            this.txtNumeroPasso.Size = new System.Drawing.Size(193, 29);
            this.txtNumeroPasso.TabIndex = 35;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(36, 499);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 21);
            this.label.TabIndex = 34;
            this.label.Text = "Passo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 821);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Resultado Esperado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(430, 1545);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 48);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarCenario
            // 
            this.btnFinalizarCenario.Location = new System.Drawing.Point(596, 1544);
            this.btnFinalizarCenario.Name = "btnFinalizarCenario";
            this.btnFinalizarCenario.Size = new System.Drawing.Size(147, 48);
            this.btnFinalizarCenario.TabIndex = 30;
            this.btnFinalizarCenario.Text = "Finalizar Cenário";
            this.btnFinalizarCenario.UseVisualStyleBackColor = true;
            this.btnFinalizarCenario.Click += new System.EventHandler(this.btnFinalizarCenario_Click);
            // 
            // dgPassos
            // 
            this.dgPassos.AllowUserToAddRows = false;
            this.dgPassos.AllowUserToDeleteRows = false;
            this.dgPassos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPassos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPassos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassos.Location = new System.Drawing.Point(40, 1122);
            this.dgPassos.Name = "dgPassos";
            this.dgPassos.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPassos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPassos.RowTemplate.Height = 24;
            this.dgPassos.Size = new System.Drawing.Size(703, 409);
            this.dgPassos.TabIndex = 29;
            this.dgPassos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPassos_CellDoubleClick);
            // 
            // btnAdicionarPasso
            // 
            this.btnAdicionarPasso.Location = new System.Drawing.Point(596, 1050);
            this.btnAdicionarPasso.Name = "btnAdicionarPasso";
            this.btnAdicionarPasso.Size = new System.Drawing.Size(147, 48);
            this.btnAdicionarPasso.TabIndex = 27;
            this.btnAdicionarPasso.Text = "Adicionar Passo";
            this.btnAdicionarPasso.UseVisualStyleBackColor = true;
            this.btnAdicionarPasso.Click += new System.EventHandler(this.btnAdicionarPasso_Click);
            // 
            // txtResultadoPasso
            // 
            this.txtResultadoPasso.Location = new System.Drawing.Point(40, 843);
            this.txtResultadoPasso.Name = "txtResultadoPasso";
            this.txtResultadoPasso.Size = new System.Drawing.Size(703, 168);
            this.txtResultadoPasso.TabIndex = 26;
            this.txtResultadoPasso.Text = "";
            // 
            // txtDescricaoPasso
            // 
            this.txtDescricaoPasso.Location = new System.Drawing.Point(40, 607);
            this.txtDescricaoPasso.Name = "txtDescricaoPasso";
            this.txtDescricaoPasso.Size = new System.Drawing.Size(703, 168);
            this.txtDescricaoPasso.TabIndex = 25;
            this.txtDescricaoPasso.Text = "";
            // 
            // txtTela
            // 
            this.txtTela.Location = new System.Drawing.Point(270, 521);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(473, 29);
            this.txtTela.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Passo a Passo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Módulos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Resultado Esperado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sistema:";
            // 
            // txtSistema
            // 
            this.txtSistema.FormattingEnabled = true;
            this.txtSistema.Location = new System.Drawing.Point(40, 87);
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(410, 29);
            this.txtSistema.TabIndex = 17;
            // 
            // txtModulos
            // 
            this.txtModulos.FormattingEnabled = true;
            this.txtModulos.Location = new System.Drawing.Point(483, 87);
            this.txtModulos.Name = "txtModulos";
            this.txtModulos.Size = new System.Drawing.Size(260, 316);
            this.txtModulos.TabIndex = 16;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(40, 307);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(410, 96);
            this.txtResultado.TabIndex = 15;
            this.txtResultado.Text = "";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(40, 161);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(410, 96);
            this.txtDescricao.TabIndex = 14;
            this.txtDescricao.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Novo Cenário";
            // 
            // NovoCenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NovoCenarioForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NovoCenarioForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtSistema;
        private System.Windows.Forms.CheckedListBox txtModulos;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtNumeroPasso;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarCenario;
        private System.Windows.Forms.DataGridView dgPassos;
        private System.Windows.Forms.Button btnAdicionarPasso;
        private System.Windows.Forms.RichTextBox txtResultadoPasso;
        private System.Windows.Forms.RichTextBox txtDescricaoPasso;
        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnExcluirPasso;
    }
}