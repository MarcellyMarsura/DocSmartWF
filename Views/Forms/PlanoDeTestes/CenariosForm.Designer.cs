namespace DocSmart.Views.Forms.PlanoDeTestes
{
    partial class CenariosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCenarios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarPlano = new System.Windows.Forms.Button();
            this.btnNovoCenario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCenarios
            // 
            this.dgCenarios.AllowUserToAddRows = false;
            this.dgCenarios.AllowUserToDeleteRows = false;
            this.dgCenarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCenarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCenarios.Location = new System.Drawing.Point(12, 57);
            this.dgCenarios.Name = "dgCenarios";
            this.dgCenarios.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCenarios.RowTemplate.Height = 24;
            this.dgCenarios.Size = new System.Drawing.Size(776, 331);
            this.dgCenarios.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 44);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarPlano
            // 
            this.btnFinalizarPlano.Location = new System.Drawing.Point(487, 398);
            this.btnFinalizarPlano.Name = "btnFinalizarPlano";
            this.btnFinalizarPlano.Size = new System.Drawing.Size(143, 44);
            this.btnFinalizarPlano.TabIndex = 6;
            this.btnFinalizarPlano.Text = "Finalizar Plano";
            this.btnFinalizarPlano.UseVisualStyleBackColor = true;
            this.btnFinalizarPlano.Click += new System.EventHandler(this.btnFinalizarPlano_Click);
            // 
            // btnNovoCenario
            // 
            this.btnNovoCenario.Location = new System.Drawing.Point(645, 398);
            this.btnNovoCenario.Name = "btnNovoCenario";
            this.btnNovoCenario.Size = new System.Drawing.Size(143, 44);
            this.btnNovoCenario.TabIndex = 7;
            this.btnNovoCenario.Text = "Novo Cenário";
            this.btnNovoCenario.UseVisualStyleBackColor = true;
            this.btnNovoCenario.Click += new System.EventHandler(this.btnNovoCenario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cenários de Teste";
            // 
            // labelCarregando
            // 
            this.labelCarregando.AutoSize = true;
            this.labelCarregando.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarregando.Location = new System.Drawing.Point(243, 407);
            this.labelCarregando.Name = "labelCarregando";
            this.labelCarregando.Size = new System.Drawing.Size(148, 25);
            this.labelCarregando.TabIndex = 12;
            this.labelCarregando.Text = "Carregando . . .";
            this.labelCarregando.Visible = false;
            // 
            // CenariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCarregando);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNovoCenario);
            this.Controls.Add(this.btnFinalizarPlano);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgCenarios);
            this.Name = "CenariosForm";
            this.Activated += new System.EventHandler(this.CenariosForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CenariosForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCenarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarPlano;
        private System.Windows.Forms.Button btnNovoCenario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelCarregando;
    }
}