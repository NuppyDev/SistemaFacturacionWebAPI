namespace VisualWebAPI
{
    partial class frmHistory
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
            panelBarra = new Guna.UI2.WinForms.Guna2Panel();
            lblPanelHistory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelBarra.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(128, 128, 255);
            panelBarra.Controls.Add(lblPanelHistory);
            panelBarra.CustomizableEdges = customizableEdges1;
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(0, 0);
            panelBarra.Name = "panelBarra";
            panelBarra.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelBarra.Size = new Size(1364, 74);
            panelBarra.TabIndex = 2;
            // 
            // lblPanelHistory
            // 
            lblPanelHistory.BackColor = Color.Transparent;
            lblPanelHistory.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPanelHistory.ForeColor = Color.White;
            lblPanelHistory.IsSelectionEnabled = false;
            lblPanelHistory.Location = new Point(401, 12);
            lblPanelHistory.Name = "lblPanelHistory";
            lblPanelHistory.Size = new Size(119, 47);
            lblPanelHistory.TabIndex = 0;
            lblPanelHistory.Text = "History";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1364, 908);
            Controls.Add(panelBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistory";
            Text = "frmHistory";
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBarra;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPanelHistory;
    }
}