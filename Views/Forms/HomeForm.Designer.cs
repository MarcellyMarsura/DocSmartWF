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
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navbar1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Navbar navbar1;
    }
}