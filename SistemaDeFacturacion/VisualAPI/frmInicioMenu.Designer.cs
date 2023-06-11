namespace VisualWebAPI
{
    partial class frmInicioMenu
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
            brTitulo = new Panel();
            btnCerrarMenu = new Button();
            MenuVertical = new Panel();
            btnInitiationMenu = new Button();
            btnHistoryMenu = new Button();
            btnInformationMenu = new Button();
            panelContenedor = new Panel();
            brTitulo.SuspendLayout();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // brTitulo
            // 
            brTitulo.BackColor = Color.FromArgb(198, 139, 125);
            brTitulo.Controls.Add(btnCerrarMenu);
            brTitulo.Dock = DockStyle.Top;
            brTitulo.Location = new Point(0, 0);
            brTitulo.Margin = new Padding(2);
            brTitulo.Name = "brTitulo";
            brTitulo.Size = new Size(1105, 23);
            brTitulo.TabIndex = 0;
            brTitulo.MouseDown += brTitulo_MouseDown;
            // 
            // btnCerrarMenu
            // 
            btnCerrarMenu.BackColor = Color.Transparent;
            btnCerrarMenu.BackgroundImage = Properties.Resources.icons8_cerrar_ventana_48;
            btnCerrarMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrarMenu.FlatAppearance.BorderSize = 0;
            btnCerrarMenu.FlatAppearance.MouseOverBackColor = Color.White;
            btnCerrarMenu.FlatStyle = FlatStyle.Flat;
            btnCerrarMenu.Location = new Point(1078, 2);
            btnCerrarMenu.Margin = new Padding(2);
            btnCerrarMenu.Name = "btnCerrarMenu";
            btnCerrarMenu.Size = new Size(24, 21);
            btnCerrarMenu.TabIndex = 4;
            btnCerrarMenu.UseVisualStyleBackColor = false;
            btnCerrarMenu.Click += btnCerrarMenu_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(232, 174, 137);
            MenuVertical.Controls.Add(btnInitiationMenu);
            MenuVertical.Controls.Add(btnHistoryMenu);
            MenuVertical.Controls.Add(btnInformationMenu);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 23);
            MenuVertical.Margin = new Padding(2);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(134, 591);
            MenuVertical.TabIndex = 1;
            // 
            // btnInitiationMenu
            // 
            btnInitiationMenu.BackColor = Color.Transparent;
            btnInitiationMenu.BackgroundImage = Properties.Resources.Gatito;
            btnInitiationMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnInitiationMenu.FlatAppearance.BorderSize = 0;
            btnInitiationMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 214, 180);
            btnInitiationMenu.FlatStyle = FlatStyle.Flat;
            btnInitiationMenu.Location = new Point(5, 6);
            btnInitiationMenu.Margin = new Padding(2);
            btnInitiationMenu.Name = "btnInitiationMenu";
            btnInitiationMenu.Size = new Size(129, 126);
            btnInitiationMenu.TabIndex = 0;
            btnInitiationMenu.UseVisualStyleBackColor = false;
            btnInitiationMenu.Click += btnInitiationMenu_Click;
            // 
            // btnHistoryMenu
            // 
            btnHistoryMenu.BackColor = Color.Transparent;
            btnHistoryMenu.BackgroundImage = Properties.Resources.Factura;
            btnHistoryMenu.BackgroundImageLayout = ImageLayout.Center;
            btnHistoryMenu.FlatAppearance.BorderSize = 0;
            btnHistoryMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 214, 180);
            btnHistoryMenu.FlatStyle = FlatStyle.Flat;
            btnHistoryMenu.Location = new Point(43, 210);
            btnHistoryMenu.Margin = new Padding(2);
            btnHistoryMenu.Name = "btnHistoryMenu";
            btnHistoryMenu.Size = new Size(91, 78);
            btnHistoryMenu.TabIndex = 2;
            btnHistoryMenu.UseVisualStyleBackColor = false;
            btnHistoryMenu.Click += btnHistoryMenu_Click;
            // 
            // btnInformationMenu
            // 
            btnInformationMenu.BackColor = Color.Transparent;
            btnInformationMenu.BackgroundImage = Properties.Resources.Informacion;
            btnInformationMenu.BackgroundImageLayout = ImageLayout.Center;
            btnInformationMenu.FlatAppearance.BorderSize = 0;
            btnInformationMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 214, 180);
            btnInformationMenu.FlatStyle = FlatStyle.Flat;
            btnInformationMenu.Location = new Point(43, 362);
            btnInformationMenu.Margin = new Padding(2);
            btnInformationMenu.Name = "btnInformationMenu";
            btnInformationMenu.Size = new Size(91, 78);
            btnInformationMenu.TabIndex = 1;
            btnInformationMenu.UseVisualStyleBackColor = false;
            btnInformationMenu.Click += btnInformationMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSize = true;
            panelContenedor.BackColor = Color.FromArgb(244, 214, 180);
            panelContenedor.BackgroundImageLayout = ImageLayout.Center;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(134, 23);
            panelContenedor.Margin = new Padding(2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(971, 591);
            panelContenedor.TabIndex = 2;
            // 
            // frmInicioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 614);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(brTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmInicioMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicioMenu";
            Load += FrmInicioMenu_Load;
            brTitulo.ResumeLayout(false);
            MenuVertical.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel brTitulo;
        private Panel MenuVertical;
        private Button btnInitiationMenu;
        private Button btnCerrarMenu;
        private Button btnHistoryMenu;
        private Button btnInformationMenu;
        private Button btnInitiationM;
        public Panel panelContenedor;
    }
}