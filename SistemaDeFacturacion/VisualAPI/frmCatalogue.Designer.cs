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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panelTCM = new Panel();
            tcMenu = new TabControl();
            tpBebida = new TabPage();
            btnBebida3 = new Button();
            btnBebida6 = new Button();
            btnBebida5 = new Button();
            btnBebida2 = new Button();
            btnBebida4 = new Button();
            btnBebida1 = new Button();
            tpComida = new TabPage();
            btnComida3 = new Button();
            btnComida6 = new Button();
            btnComida5 = new Button();
            btnComida2 = new Button();
            btnComida4 = new Button();
            btnComida1 = new Button();
            panelDgv = new Panel();
            btnImprimir = new Button();
            btnCancelar = new Button();
            dgvDatos = new DataGridView();
            btnMas = new Button();
            btnMenos = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCantComprar = new Label();
            lblPrecio = new Label();
            pictureBox1 = new PictureBox();
            ImprimirFactura = new System.Drawing.Printing.PrintDocument();
            panelTCM.SuspendLayout();
            tcMenu.SuspendLayout();
            tpBebida.SuspendLayout();
            tpComida.SuspendLayout();
            panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTCM
            // 
            panelTCM.Controls.Add(tcMenu);
            panelTCM.Dock = DockStyle.Bottom;
            panelTCM.Location = new Point(0, 221);
            panelTCM.Margin = new Padding(2);
            panelTCM.Name = "panelTCM";
            panelTCM.Size = new Size(623, 370);
            panelTCM.TabIndex = 1;
            // 
            // tcMenu
            // 
            tcMenu.Controls.Add(tpBebida);
            tcMenu.Controls.Add(tpComida);
            tcMenu.Dock = DockStyle.Fill;
            tcMenu.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tcMenu.Location = new Point(0, 0);
            tcMenu.Margin = new Padding(2);
            tcMenu.Name = "tcMenu";
            tcMenu.SelectedIndex = 0;
            tcMenu.Size = new Size(623, 370);
            tcMenu.TabIndex = 0;
            // 
            // tpBebida
            // 
            tpBebida.BackColor = Color.FromArgb(198, 139, 125);
            tpBebida.Controls.Add(btnBebida3);
            tpBebida.Controls.Add(btnBebida6);
            tpBebida.Controls.Add(btnBebida5);
            tpBebida.Controls.Add(btnBebida2);
            tpBebida.Controls.Add(btnBebida4);
            tpBebida.Controls.Add(btnBebida1);
            tpBebida.Cursor = Cursors.Hand;
            tpBebida.ForeColor = Color.White;
            tpBebida.Location = new Point(4, 25);
            tpBebida.Margin = new Padding(2);
            tpBebida.Name = "tpBebida";
            tpBebida.Padding = new Padding(2);
            tpBebida.Size = new Size(615, 341);
            tpBebida.TabIndex = 0;
            tpBebida.Text = "BEBIDA";
            // 
            // btnBebida3
            // 
            btnBebida3.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida3.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida3.FlatAppearance.BorderSize = 0;
            btnBebida3.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida3.FlatStyle = FlatStyle.Flat;
            btnBebida3.ForeColor = Color.White;
            btnBebida3.Image = Properties.Resources.TéCaliente;
            btnBebida3.Location = new Point(427, 24);
            btnBebida3.Margin = new Padding(2);
            btnBebida3.Name = "btnBebida3";
            btnBebida3.Size = new Size(140, 114);
            btnBebida3.TabIndex = 42;
            btnBebida3.Text = "Té Caliente";
            btnBebida3.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida3.UseVisualStyleBackColor = false;
            // 
            // btnBebida6
            // 
            btnBebida6.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida6.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida6.FlatAppearance.BorderSize = 0;
            btnBebida6.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida6.FlatStyle = FlatStyle.Flat;
            btnBebida6.ForeColor = Color.White;
            btnBebida6.Image = Properties.Resources.CaféCaliente;
            btnBebida6.Location = new Point(427, 189);
            btnBebida6.Margin = new Padding(2);
            btnBebida6.Name = "btnBebida6";
            btnBebida6.Size = new Size(140, 114);
            btnBebida6.TabIndex = 41;
            btnBebida6.Text = "Café Caliente";
            btnBebida6.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida6.UseVisualStyleBackColor = false;
            // 
            // btnBebida5
            // 
            btnBebida5.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida5.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida5.FlatAppearance.BorderSize = 0;
            btnBebida5.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida5.FlatStyle = FlatStyle.Flat;
            btnBebida5.ForeColor = Color.White;
            btnBebida5.Image = Properties.Resources.CaféHelado;
            btnBebida5.Location = new Point(236, 189);
            btnBebida5.Margin = new Padding(2);
            btnBebida5.Name = "btnBebida5";
            btnBebida5.Size = new Size(140, 114);
            btnBebida5.TabIndex = 40;
            btnBebida5.Text = "Café Helado";
            btnBebida5.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida5.UseVisualStyleBackColor = false;
            // 
            // btnBebida2
            // 
            btnBebida2.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida2.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida2.FlatAppearance.BorderSize = 0;
            btnBebida2.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida2.FlatStyle = FlatStyle.Flat;
            btnBebida2.ForeColor = Color.White;
            btnBebida2.Image = Properties.Resources.TéDeLimon;
            btnBebida2.Location = new Point(236, 24);
            btnBebida2.Margin = new Padding(2);
            btnBebida2.Name = "btnBebida2";
            btnBebida2.Size = new Size(140, 114);
            btnBebida2.TabIndex = 39;
            btnBebida2.Text = "Té de Limón";
            btnBebida2.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida2.UseVisualStyleBackColor = false;
            // 
            // btnBebida4
            // 
            btnBebida4.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida4.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida4.FlatAppearance.BorderSize = 0;
            btnBebida4.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida4.FlatStyle = FlatStyle.Flat;
            btnBebida4.ForeColor = Color.White;
            btnBebida4.Image = Properties.Resources.Limonada;
            btnBebida4.Location = new Point(44, 189);
            btnBebida4.Margin = new Padding(2);
            btnBebida4.Name = "btnBebida4";
            btnBebida4.Size = new Size(140, 114);
            btnBebida4.TabIndex = 38;
            btnBebida4.Text = "Limonada";
            btnBebida4.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida4.UseVisualStyleBackColor = false;
            // 
            // btnBebida1
            // 
            btnBebida1.BackColor = Color.FromArgb(232, 174, 137);
            btnBebida1.BackgroundImageLayout = ImageLayout.Stretch;
            btnBebida1.FlatAppearance.BorderSize = 0;
            btnBebida1.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBebida1.FlatStyle = FlatStyle.Flat;
            btnBebida1.ForeColor = Color.White;
            btnBebida1.Image = Properties.Resources.Frapuccino;
            btnBebida1.ImageAlign = ContentAlignment.TopCenter;
            btnBebida1.Location = new Point(44, 24);
            btnBebida1.Margin = new Padding(2);
            btnBebida1.Name = "btnBebida1";
            btnBebida1.Size = new Size(140, 114);
            btnBebida1.TabIndex = 37;
            btnBebida1.Text = "Frapurrccino";
            btnBebida1.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBebida1.UseVisualStyleBackColor = false;
            // 
            // tpComida
            // 
            tpComida.BackColor = Color.FromArgb(198, 139, 125);
            tpComida.Controls.Add(btnComida3);
            tpComida.Controls.Add(btnComida6);
            tpComida.Controls.Add(btnComida5);
            tpComida.Controls.Add(btnComida2);
            tpComida.Controls.Add(btnComida4);
            tpComida.Controls.Add(btnComida1);
            tpComida.Location = new Point(4, 25);
            tpComida.Margin = new Padding(2);
            tpComida.Name = "tpComida";
            tpComida.Padding = new Padding(2);
            tpComida.Size = new Size(615, 341);
            tpComida.TabIndex = 1;
            tpComida.Text = "COMIDA";
            // 
            // btnComida3
            // 
            btnComida3.BackColor = Color.FromArgb(232, 174, 137);
            btnComida3.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida3.Cursor = Cursors.Hand;
            btnComida3.FlatAppearance.BorderSize = 0;
            btnComida3.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida3.FlatStyle = FlatStyle.Flat;
            btnComida3.ForeColor = Color.White;
            btnComida3.Image = Properties.Resources.PapitaFrita;
            btnComida3.Location = new Point(426, 30);
            btnComida3.Margin = new Padding(2);
            btnComida3.Name = "btnComida3";
            btnComida3.Size = new Size(140, 114);
            btnComida3.TabIndex = 48;
            btnComida3.Text = "Papas Fritas";
            btnComida3.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida3.UseVisualStyleBackColor = false;
            // 
            // btnComida6
            // 
            btnComida6.BackColor = Color.FromArgb(232, 174, 137);
            btnComida6.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida6.Cursor = Cursors.Hand;
            btnComida6.FlatAppearance.BorderSize = 0;
            btnComida6.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida6.FlatStyle = FlatStyle.Flat;
            btnComida6.ForeColor = Color.White;
            btnComida6.Image = Properties.Resources.RosquillasViejitasSomoteñas;
            btnComida6.Location = new Point(426, 192);
            btnComida6.Margin = new Padding(2);
            btnComida6.Name = "btnComida6";
            btnComida6.Size = new Size(140, 114);
            btnComida6.TabIndex = 47;
            btnComida6.Text = "Rosquillas y viejitas";
            btnComida6.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida6.UseVisualStyleBackColor = false;
            // 
            // btnComida5
            // 
            btnComida5.BackColor = Color.FromArgb(232, 174, 137);
            btnComida5.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida5.Cursor = Cursors.Hand;
            btnComida5.FlatAppearance.BorderSize = 0;
            btnComida5.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida5.FlatStyle = FlatStyle.Flat;
            btnComida5.ForeColor = Color.White;
            btnComida5.Image = Properties.Resources.GelatinaCafé;
            btnComida5.Location = new Point(235, 192);
            btnComida5.Margin = new Padding(2);
            btnComida5.Name = "btnComida5";
            btnComida5.Size = new Size(140, 114);
            btnComida5.TabIndex = 46;
            btnComida5.Text = "Gomitas de Café";
            btnComida5.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida5.UseVisualStyleBackColor = false;
            // 
            // btnComida2
            // 
            btnComida2.BackColor = Color.FromArgb(232, 174, 137);
            btnComida2.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida2.Cursor = Cursors.Hand;
            btnComida2.FlatAppearance.BorderSize = 0;
            btnComida2.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida2.FlatStyle = FlatStyle.Flat;
            btnComida2.ForeColor = Color.White;
            btnComida2.Image = Properties.Resources.PaniniQueso;
            btnComida2.Location = new Point(235, 30);
            btnComida2.Margin = new Padding(2);
            btnComida2.Name = "btnComida2";
            btnComida2.Size = new Size(140, 114);
            btnComida2.TabIndex = 45;
            btnComida2.Text = "Panini de queso";
            btnComida2.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida2.UseVisualStyleBackColor = false;
            // 
            // btnComida4
            // 
            btnComida4.BackColor = Color.FromArgb(232, 174, 137);
            btnComida4.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida4.Cursor = Cursors.Hand;
            btnComida4.FlatAppearance.BorderSize = 0;
            btnComida4.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida4.FlatStyle = FlatStyle.Flat;
            btnComida4.ForeColor = Color.White;
            btnComida4.Image = Properties.Resources.SliceTorta;
            btnComida4.Location = new Point(43, 192);
            btnComida4.Margin = new Padding(2);
            btnComida4.Name = "btnComida4";
            btnComida4.Size = new Size(140, 114);
            btnComida4.TabIndex = 44;
            btnComida4.Text = "Slice de Torta Marmoleada";
            btnComida4.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida4.UseVisualStyleBackColor = false;
            // 
            // btnComida1
            // 
            btnComida1.BackColor = Color.FromArgb(232, 174, 137);
            btnComida1.BackgroundImageLayout = ImageLayout.Stretch;
            btnComida1.Cursor = Cursors.Hand;
            btnComida1.FlatAppearance.BorderSize = 0;
            btnComida1.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComida1.FlatStyle = FlatStyle.Flat;
            btnComida1.ForeColor = Color.White;
            btnComida1.Image = Properties.Resources.PanCake;
            btnComida1.Location = new Point(43, 30);
            btnComida1.Margin = new Padding(2);
            btnComida1.Name = "btnComida1";
            btnComida1.Size = new Size(140, 114);
            btnComida1.TabIndex = 43;
            btnComida1.Text = "Panqueque";
            btnComida1.TextImageRelation = TextImageRelation.TextAboveImage;
            btnComida1.UseVisualStyleBackColor = false;
            // 
            // panelDgv
            // 
            panelDgv.BackColor = Color.FromArgb(255, 147, 118);
            panelDgv.Controls.Add(btnImprimir);
            panelDgv.Controls.Add(btnCancelar);
            panelDgv.Controls.Add(dgvDatos);
            panelDgv.Dock = DockStyle.Right;
            panelDgv.Location = new Point(623, 0);
            panelDgv.Margin = new Padding(2);
            panelDgv.Name = "panelDgv";
            panelDgv.Size = new Size(347, 591);
            panelDgv.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(232, 174, 137);
            btnImprimir.BackgroundImageLayout = ImageLayout.Center;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(202, 491);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(130, 44);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(232, 174, 137);
            btnCancelar.BackgroundImageLayout = ImageLayout.Center;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(14, 491);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDatos.BackgroundColor = Color.FromArgb(198, 139, 125);
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvDatos.ColumnHeadersHeight = 45;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle10;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.Maroon;
            dgvDatos.Location = new Point(14, 43);
            dgvDatos.Margin = new Padding(1);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Salmon;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvDatos.RowTemplate.Height = 33;
            dgvDatos.Size = new Size(318, 341);
            dgvDatos.TabIndex = 2;
            // 
            // btnMas
            // 
            btnMas.BackColor = Color.Transparent;
            btnMas.BackgroundImage = Properties.Resources.icons8_más_48;
            btnMas.BackgroundImageLayout = ImageLayout.Center;
            btnMas.Cursor = Cursors.Hand;
            btnMas.FlatAppearance.BorderSize = 0;
            btnMas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMas.FlatStyle = FlatStyle.Flat;
            btnMas.Location = new Point(363, 113);
            btnMas.Margin = new Padding(2);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(60, 49);
            btnMas.TabIndex = 3;
            btnMas.UseVisualStyleBackColor = false;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = Color.Transparent;
            btnMenos.BackgroundImage = Properties.Resources.icons8_menos_48;
            btnMenos.BackgroundImageLayout = ImageLayout.Center;
            btnMenos.Cursor = Cursors.Hand;
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Location = new Point(244, 113);
            btnMenos.Margin = new Padding(2);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(60, 49);
            btnMenos.TabIndex = 4;
            btnMenos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 27);
            label1.TabIndex = 5;
            label1.Text = "Comida o Bebida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(240, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            // 
            // lblCantComprar
            // 
            lblCantComprar.AutoSize = true;
            lblCantComprar.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCantComprar.Location = new Point(308, 127);
            lblCantComprar.Margin = new Padding(2, 0, 2, 0);
            lblCantComprar.Name = "lblCantComprar";
            lblCantComprar.Size = new Size(50, 21);
            lblCantComprar.TabIndex = 7;
            lblCantComprar.Text = "_____";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(303, 72);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(75, 21);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "C$ 00.00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Gatito;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(48, 72);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 73);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmCatalogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 214, 180);
            ClientSize = new Size(970, 591);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantComprar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(panelTCM);
            Controls.Add(panelDgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmCatalogue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCatalogue";
            panelTCM.ResumeLayout(false);
            tcMenu.ResumeLayout(false);
            tpBebida.ResumeLayout(false);
            tpComida.ResumeLayout(false);
            panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTCM;
        private Panel panelDgv;
        private DataGridView dgvDatos;
        private TabControl tcMenu;
        private TabPage tpBebida;
        private TabPage tpComida;
        private Button btnImprimir;
        private Button btnCancelar;
        private Button btnMas;
        private Button btnMenos;
        private Label label1;
        private Label label2;
        private Label lblCantComprar;
        private Label lblPrecio;
        private PictureBox pictureBox1;
        private Button btnBebida3;
        private Button btnBebida6;
        private Button btnBebida5;
        private Button btnBebida2;
        private Button btnBebida4;
        private Button btnBebida1;
        private Button btnComida3;
        private Button btnComida6;
        private Button btnComida5;
        private Button btnComida2;
        private Button btnComida4;
        private Button btnComida1;
        private System.Drawing.Printing.PrintDocument ImprimirFactura;
    }
}