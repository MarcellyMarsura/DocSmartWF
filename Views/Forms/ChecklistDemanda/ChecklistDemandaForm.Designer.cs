namespace DocSmart.Views.Forms.ChecklistDemanda
{
    partial class ChecklistDemandaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormalizacao = new System.Windows.Forms.CheckedListBox();
            this.txtPlanejamento = new System.Windows.Forms.CheckedListBox();
            this.txtDesenho = new System.Windows.Forms.CheckedListBox();
            this.txtConstrucao = new System.Windows.Forms.CheckedListBox();
            this.txtTeste = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.txtSuporte = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Checklist da Demanda";
            // 
            // txtFormalizacao
            // 
            this.txtFormalizacao.CheckOnClick = true;
            this.txtFormalizacao.FormattingEnabled = true;
            this.txtFormalizacao.HorizontalScrollbar = true;
            this.txtFormalizacao.Location = new System.Drawing.Point(26, 97);
            this.txtFormalizacao.Name = "txtFormalizacao";
            this.txtFormalizacao.Size = new System.Drawing.Size(345, 220);
            this.txtFormalizacao.TabIndex = 10;
            // 
            // txtPlanejamento
            // 
            this.txtPlanejamento.CheckOnClick = true;
            this.txtPlanejamento.FormattingEnabled = true;
            this.txtPlanejamento.HorizontalScrollbar = true;
            this.txtPlanejamento.Location = new System.Drawing.Point(405, 97);
            this.txtPlanejamento.Name = "txtPlanejamento";
            this.txtPlanejamento.Size = new System.Drawing.Size(345, 220);
            this.txtPlanejamento.TabIndex = 11;
            // 
            // txtDesenho
            // 
            this.txtDesenho.CheckOnClick = true;
            this.txtDesenho.FormattingEnabled = true;
            this.txtDesenho.HorizontalScrollbar = true;
            this.txtDesenho.Location = new System.Drawing.Point(26, 375);
            this.txtDesenho.Name = "txtDesenho";
            this.txtDesenho.Size = new System.Drawing.Size(345, 220);
            this.txtDesenho.TabIndex = 12;
            // 
            // txtConstrucao
            // 
            this.txtConstrucao.CheckOnClick = true;
            this.txtConstrucao.FormattingEnabled = true;
            this.txtConstrucao.HorizontalScrollbar = true;
            this.txtConstrucao.Location = new System.Drawing.Point(405, 375);
            this.txtConstrucao.Name = "txtConstrucao";
            this.txtConstrucao.Size = new System.Drawing.Size(345, 220);
            this.txtConstrucao.TabIndex = 13;
            // 
            // txtTeste
            // 
            this.txtTeste.CheckOnClick = true;
            this.txtTeste.FormattingEnabled = true;
            this.txtTeste.HorizontalScrollbar = true;
            this.txtTeste.Location = new System.Drawing.Point(26, 650);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(345, 220);
            this.txtTeste.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGerarArquivo);
            this.panel1.Controls.Add(this.txtSuporte);
            this.panel1.Controls.Add(this.txtFormalizacao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtConstrucao);
            this.panel1.Controls.Add(this.txtTeste);
            this.panel1.Controls.Add(this.txtPlanejamento);
            this.panel1.Controls.Add(this.txtDesenho);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 956);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Suporte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Testes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Construção:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Desenho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Planejamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Formalização:";
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(604, 890);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(146, 54);
            this.btnGerarArquivo.TabIndex = 16;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // txtSuporte
            // 
            this.txtSuporte.CheckOnClick = true;
            this.txtSuporte.FormattingEnabled = true;
            this.txtSuporte.HorizontalScrollbar = true;
            this.txtSuporte.Location = new System.Drawing.Point(405, 650);
            this.txtSuporte.Name = "txtSuporte";
            this.txtSuporte.Size = new System.Drawing.Size(345, 220);
            this.txtSuporte.TabIndex = 15;
            // 
            // ChecklistDemandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ChecklistDemandaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocSmart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChecklistDemandaForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox txtFormalizacao;
        private System.Windows.Forms.CheckedListBox txtPlanejamento;
        private System.Windows.Forms.CheckedListBox txtDesenho;
        private System.Windows.Forms.CheckedListBox txtConstrucao;
        private System.Windows.Forms.CheckedListBox txtTeste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.CheckedListBox txtSuporte;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}