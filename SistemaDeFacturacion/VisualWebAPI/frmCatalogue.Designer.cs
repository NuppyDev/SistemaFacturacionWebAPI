namespace VisualWebAPI
{
    partial class frmCatalogue
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
            panelBarraCatalogue = new Guna.UI2.WinForms.Guna2Panel();
            lblPanelHistory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelBarraCatalogue.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarraCatalogue
            // 
            panelBarraCatalogue.BackColor = Color.FromArgb(128, 128, 255);
            panelBarraCatalogue.Controls.Add(lblPanelHistory);
            panelBarraCatalogue.CustomizableEdges = customizableEdges1;
            panelBarraCatalogue.Dock = DockStyle.Top;
            panelBarraCatalogue.Location = new Point(0, 0);
            panelBarraCatalogue.Name = "panelBarraCatalogue";
            panelBarraCatalogue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelBarraCatalogue.Size = new Size(1364, 74);
            panelBarraCatalogue.TabIndex = 3;
            // 
            // lblPanelHistory
            // 
            lblPanelHistory.BackColor = Color.Transparent;
            lblPanelHistory.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPanelHistory.ForeColor = Color.White;
            lblPanelHistory.IsSelectionEnabled = false;
            lblPanelHistory.Location = new Point(401, 12);
            lblPanelHistory.Name = "lblPanelHistory";
            lblPanelHistory.Size = new Size(191, 47);
            lblPanelHistory.TabIndex = 0;
            lblPanelHistory.Text = "Catalogue";
            // 
            // frmCatalogue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1364, 908);
            Controls.Add(panelBarraCatalogue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCatalogue";
            Text = "frmCatalogue";
            panelBarraCatalogue.ResumeLayout(false);
            panelBarraCatalogue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBarraCatalogue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPanelHistory;
    }
}