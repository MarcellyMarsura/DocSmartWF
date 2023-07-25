namespace DocSmart.Views.Forms.ControleTestes
{
    partial class ControleTestesForm
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
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnPlanoTeste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPathPasta = new System.Windows.Forms.TextBox();
            this.txtPathPlano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(328, 360);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(149, 63);
            this.btnGerarArquivo.TabIndex = 15;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.Location = new System.Drawing.Point(623, 247);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(149, 63);
            this.btnPasta.TabIndex = 14;
            this.btnPasta.Text = "Selecione";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnPlanoTeste
            // 
            this.btnPlanoTeste.Location = new System.Drawing.Point(623, 119);
            this.btnPlanoTeste.Name = "btnPlanoTeste";
            this.btnPlanoTeste.Size = new System.Drawing.Size(149, 56);
            this.btnPlanoTeste.TabIndex = 13;
            this.btnPlanoTeste.Text = "Selecione";
            this.btnPlanoTeste.UseVisualStyleBackColor = true;
            this.btnPlanoTeste.Click += new System.EventHandler(this.btnPlanoTeste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diretório da Pasta:";
            // 
            // txtPathPasta
            // 
            this.txtPathPasta.Enabled = false;
            this.txtPathPasta.Location = new System.Drawing.Point(32, 247);
            this.txtPathPasta.Multiline = true;
            this.txtPathPasta.Name = "txtPathPasta";
            this.txtPathPasta.ReadOnly = true;
            this.txtPathPasta.Size = new System.Drawing.Size(564, 63);
            this.txtPathPasta.TabIndex = 11;
            // 
            // txtPathPlano
            // 
            this.txtPathPlano.Enabled = false;
            this.txtPathPlano.Location = new System.Drawing.Point(32, 119);
            this.txtPathPlano.Multiline = true;
            this.txtPathPlano.Name = "txtPathPlano";
            this.txtPathPlano.ReadOnly = true;
            this.txtPathPlano.Size = new System.Drawing.Size(564, 56);
            this.txtPathPlano.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Diretório do Plano de Testes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Controle de Testes";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ControleTestesForm
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
            this.Name = "ControleTestesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocSmart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnPlanoTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPathPasta;
        private System.Windows.Forms.TextBox txtPathPlano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}