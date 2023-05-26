namespace VisualWebAPI
{
    partial class frmInformation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(402, 32);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(581, 47);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Información de nuestro proyecto";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblPrecio);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1386, 105);
            guna2Panel1.TabIndex = 1;
            // 
            // frmInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1386, 964);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInformation";
            Text = "frmInformation";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}