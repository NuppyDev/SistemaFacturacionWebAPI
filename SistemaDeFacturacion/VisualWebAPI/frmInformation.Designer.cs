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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelBarra = new Guna.UI2.WinForms.Guna2Panel();
            panelBarra.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.IsSelectionEnabled = false;
            lblPrecio.Location = new Point(401, 12);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(581, 47);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Información de nuestro proyecto";
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(128, 128, 255);
            panelBarra.Controls.Add(lblPrecio);
            panelBarra.CustomizableEdges = customizableEdges1;
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Name = "panelBarra";
            panelBarra.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelBarra.Size = new Size(1386, 74);
            panelBarra.TabIndex = 1;
            // 
            // frmInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1386, 964);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInformation";
            Text = "frmInformation";
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private Guna.UI2.WinForms.Guna2Panel panelBarra;
    }
}