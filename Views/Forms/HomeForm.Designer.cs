namespace DocSmart.Views.Forms
{
    partial class HomeForm
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
            this.navbar1 = new DocSmart.Views.Componentes.Navbar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChecklistDemanda = new System.Windows.Forms.Button();
            this.btnControleTestes = new System.Windows.Forms.Button();
            this.btnDocumentacaoDeTeste = new System.Windows.Forms.Button();
            this.btnPlanoDeTestes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.navbar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbar1.Location = new System.Drawing.Point(-8, 1);
            this.navbar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(816, 50);
            this.navbar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automatize e Simplifique sua documentação de Projetos de Desenvolvimento.";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(66, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crie, padronize e agilize a produção de documentação de projetos!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(70, 261);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(264, 29);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(70, 334);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 29);
            this.txtSenha.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(142, 379);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 41);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChecklistDemanda);
            this.panel1.Controls.Add(this.btnControleTestes);
            this.panel1.Controls.Add(this.btnDocumentacaoDeTeste);
            this.panel1.Controls.Add(this.btnPlanoDeTestes);
            this.panel1.Location = new System.Drawing.Point(448, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 8;
            // 
            // btnChecklistDemanda
            // 
            this.btnChecklistDemanda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecklistDemanda.Location = new System.Drawing.Point(159, 157);
            this.btnChecklistDemanda.Name = "btnChecklistDemanda";
            this.btnChecklistDemanda.Size = new System.Drawing.Size(125, 125);
            this.btnChecklistDemanda.TabIndex = 3;
            this.btnChecklistDemanda.Text = "Checklist da Demanda";
            this.btnChecklistDemanda.UseVisualStyleBackColor = true;
            this.btnChecklistDemanda.Click += new System.EventHandler(this.btnChecklistDemanda_Click);
            // 
            // btnControleTestes
            // 
            this.btnControleTestes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleTestes.Location = new System.Drawing.Point(19, 157);
            this.btnControleTestes.Name = "btnControleTestes";
            this.btnControleTestes.Size = new System.Drawing.Size(125, 125);
            this.btnControleTestes.TabIndex = 2;
            this.btnControleTestes.Text = "Controle de Testes";
            this.btnControleTestes.UseVisualStyleBackColor = true;
            this.btnControleTestes.Click += new System.EventHandler(this.btnControleTestes_Click);
            // 
            // btnDocumentacaoDeTeste
            // 
            this.btnDocumentacaoDeTeste.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentacaoDeTeste.Location = new System.Drawing.Point(159, 14);
            this.btnDocumentacaoDeTeste.Name = "btnDocumentacaoDeTeste";
            this.btnDocumentacaoDeTeste.Size = new System.Drawing.Size(125, 125);
            this.btnDocumentacaoDeTeste.TabIndex = 1;
            this.btnDocumentacaoDeTeste.Text = "Documentação de Testes";
            this.btnDocumentacaoDeTeste.UseVisualStyleBackColor = true;
            this.btnDocumentacaoDeTeste.Click += new System.EventHandler(this.btnDocumentacaoDeTeste_Click);
            // 
            // btnPlanoDeTestes
            // 
            this.btnPlanoDeTestes.BackColor = System.Drawing.Color.White;
            this.btnPlanoDeTestes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanoDeTestes.Location = new System.Drawing.Point(19, 14);
            this.btnPlanoDeTestes.Name = "btnPlanoDeTestes";
            this.btnPlanoDeTestes.Size = new System.Drawing.Size(125, 125);
            this.btnPlanoDeTestes.TabIndex = 0;
            this.btnPlanoDeTestes.Text = "Plano de Testes";
            this.btnPlanoDeTestes.UseVisualStyleBackColor = false;
            this.btnPlanoDeTestes.Click += new System.EventHandler(this.btnPlanoDeTestes_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navbar1);
            this.Name = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Navbar navbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChecklistDemanda;
        private System.Windows.Forms.Button btnControleTestes;
        private System.Windows.Forms.Button btnDocumentacaoDeTeste;
        private System.Windows.Forms.Button btnPlanoDeTestes;
    }
}