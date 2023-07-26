namespace DocSmart.Views.Forms.DocumentacaoTestes
{
    partial class DocumentacaoTestesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPlano = new System.Windows.Forms.TextBox();
            this.txtPathPasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlanoTeste = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documentação de Testes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diretório do Plano de Testes:";
            // 
            // txtPathPlano
            // 
            this.txtPathPlano.Enabled = false;
            this.txtPathPlano.Location = new System.Drawing.Point(32, 116);
            this.txtPathPlano.Multiline = true;
            this.txtPathPlano.Name = "txtPathPlano";
            this.txtPathPlano.ReadOnly = true;
            this.txtPathPlano.Size = new System.Drawing.Size(564, 56);
            this.txtPathPlano.TabIndex = 2;
            // 
            // txtPathPasta
            // 
            this.txtPathPasta.Enabled = false;
            this.txtPathPasta.Location = new System.Drawing.Point(32, 244);
            this.txtPathPasta.Multiline = true;
            this.txtPathPasta.Name = "txtPathPasta";
            this.txtPathPasta.ReadOnly = true;
            this.txtPathPasta.Size = new System.Drawing.Size(564, 63);
            this.txtPathPasta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diretório da Pasta:";
            // 
            // btnPlanoTeste
            // 
            this.btnPlanoTeste.Location = new System.Drawing.Point(623, 116);
            this.btnPlanoTeste.Name = "btnPlanoTeste";
            this.btnPlanoTeste.Size = new System.Drawing.Size(149, 56);
            this.btnPlanoTeste.TabIndex = 5;
            this.btnPlanoTeste.Text = "Selecione";
            this.btnPlanoTeste.UseVisualStyleBackColor = true;
            this.btnPlanoTeste.Click += new System.EventHandler(this.btnPlanoTeste_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.Location = new System.Drawing.Point(623, 244);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(149, 63);
            this.btnPasta.TabIndex = 6;
            this.btnPasta.Text = "Selecione";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(328, 357);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(149, 63);
            this.btnGerarArquivo.TabIndex = 7;
            this.btnGerarArquivo.Text = "Gerar Arquivos";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // DocumentacaoTestesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnPlanoTeste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPathPasta);
            this.Controls.Add(this.txtPathPlano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DocumentacaoTestesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocSmart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentacaoTestesForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPlano;
        private System.Windows.Forms.TextBox txtPathPasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlanoTeste;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}