namespace VisualWebAPI
{
    partial class frmInicioSala
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            brTitulo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            MenuVertical = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            panelContenedor = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // brTitulo
            // 
            brTitulo.CustomizableEdges = customizableEdges1;
            brTitulo.Dock = DockStyle.Top;
            brTitulo.FillColor = Color.FromArgb(128, 128, 255);
            brTitulo.FillColor2 = Color.FromArgb(224, 224, 224);
            brTitulo.FillColor3 = Color.FromArgb(255, 192, 255);
            brTitulo.FillColor4 = Color.FromArgb(128, 128, 255);
            brTitulo.Location = new Point(0, 0);
            brTitulo.Name = "brTitulo";
            brTitulo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            brTitulo.Size = new Size(1578, 60);
            brTitulo.TabIndex = 0;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.White;
            MenuVertical.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            MenuVertical.CustomBorderColor = Color.White;
            MenuVertical.CustomizableEdges = customizableEdges3;
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.FillColor2 = Color.FromArgb(255, 192, 255);
            MenuVertical.FillColor3 = Color.FromArgb(128, 128, 255);
            MenuVertical.FillColor4 = Color.FromArgb(192, 192, 255);
            MenuVertical.Location = new Point(0, 60);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.ShadowDecoration.CustomizableEdges = customizableEdges4;
            MenuVertical.Size = new Size(192, 964);
            MenuVertical.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.CustomizableEdges = customizableEdges5;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.FillColor = Color.FromArgb(128, 128, 255);
            panelContenedor.FillColor2 = Color.FromArgb(224, 224, 224);
            panelContenedor.FillColor3 = Color.FromArgb(255, 192, 255);
            panelContenedor.FillColor4 = Color.FromArgb(128, 128, 255);
            panelContenedor.Location = new Point(192, 60);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelContenedor.Size = new Size(1386, 964);
            panelContenedor.TabIndex = 9;
            // 
            // frmInicioSala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1024);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(brTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicioSala";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicioSala";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel brTitulo;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MenuVertical;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelContenedor;
    }
}