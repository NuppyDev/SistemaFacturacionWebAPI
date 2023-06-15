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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelTCM = new Panel();
            tcMenu = new TabControl();
            tpBebida = new TabPage();
            btnTeCaliente = new Button();
            btnCafeCaliente = new Button();
            btnCafeHelado = new Button();
            btnTeLimon = new Button();
            btnLimonada = new Button();
            btnFrapurrccino = new Button();
            tpComida = new TabPage();
            btnPapas = new Button();
            btnRosquillas = new Button();
            btnGomitas = new Button();
            btnPanini = new Button();
            btnTorta = new Button();
            btnPanqueque = new Button();
            panelDgv = new Panel();
            btnImprimir = new Button();
            btnCancelar = new Button();
            dgvDatos = new DataGridView();
            btnMas = new Button();
            btnMenos = new Button();
            lblNombre = new Label();
            label2 = new Label();
            lblCantComprar = new Label();
            lblPrecio = new Label();
            pictureBox1 = new PictureBox();
            ImprimirFactura = new System.Drawing.Printing.PrintDocument();
            btnAgregar = new Button();
            lblCantidad = new Label();
            label1 = new Label();
            lblCodigo = new Label();
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
            tpBebida.Controls.Add(btnTeCaliente);
            tpBebida.Controls.Add(btnCafeCaliente);
            tpBebida.Controls.Add(btnCafeHelado);
            tpBebida.Controls.Add(btnTeLimon);
            tpBebida.Controls.Add(btnLimonada);
            tpBebida.Controls.Add(btnFrapurrccino);
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
            // btnTeCaliente
            // 
            btnTeCaliente.BackColor = Color.FromArgb(232, 174, 137);
            btnTeCaliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnTeCaliente.FlatAppearance.BorderSize = 0;
            btnTeCaliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnTeCaliente.FlatStyle = FlatStyle.Flat;
            btnTeCaliente.ForeColor = Color.White;
            btnTeCaliente.Image = Properties.Resources.TéCaliente;
            btnTeCaliente.Location = new Point(427, 24);
            btnTeCaliente.Margin = new Padding(2);
            btnTeCaliente.Name = "btnTeCaliente";
            btnTeCaliente.Size = new Size(140, 114);
            btnTeCaliente.TabIndex = 42;
            btnTeCaliente.Text = "Té Caliente";
            btnTeCaliente.TextImageRelation = TextImageRelation.TextAboveImage;
            btnTeCaliente.UseVisualStyleBackColor = false;
            btnTeCaliente.Click += btnTeCaliente_Click;
            // 
            // btnCafeCaliente
            // 
            btnCafeCaliente.BackColor = Color.FromArgb(232, 174, 137);
            btnCafeCaliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnCafeCaliente.FlatAppearance.BorderSize = 0;
            btnCafeCaliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCafeCaliente.FlatStyle = FlatStyle.Flat;
            btnCafeCaliente.ForeColor = Color.White;
            btnCafeCaliente.Image = Properties.Resources.CaféCaliente;
            btnCafeCaliente.Location = new Point(427, 189);
            btnCafeCaliente.Margin = new Padding(2);
            btnCafeCaliente.Name = "btnCafeCaliente";
            btnCafeCaliente.Size = new Size(140, 114);
            btnCafeCaliente.TabIndex = 41;
            btnCafeCaliente.Text = "Café Caliente";
            btnCafeCaliente.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCafeCaliente.UseVisualStyleBackColor = false;
            btnCafeCaliente.Click += btnCafeCaliente_Click;
            // 
            // btnCafeHelado
            // 
            btnCafeHelado.BackColor = Color.FromArgb(232, 174, 137);
            btnCafeHelado.BackgroundImageLayout = ImageLayout.Stretch;
            btnCafeHelado.FlatAppearance.BorderSize = 0;
            btnCafeHelado.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCafeHelado.FlatStyle = FlatStyle.Flat;
            btnCafeHelado.ForeColor = Color.White;
            btnCafeHelado.Image = Properties.Resources.CaféHelado;
            btnCafeHelado.Location = new Point(236, 189);
            btnCafeHelado.Margin = new Padding(2);
            btnCafeHelado.Name = "btnCafeHelado";
            btnCafeHelado.Size = new Size(140, 114);
            btnCafeHelado.TabIndex = 40;
            btnCafeHelado.Text = "Café Helado";
            btnCafeHelado.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCafeHelado.UseVisualStyleBackColor = false;
            btnCafeHelado.Click += btnCafeHelado_Click;
            // 
            // btnTeLimon
            // 
            btnTeLimon.BackColor = Color.FromArgb(232, 174, 137);
            btnTeLimon.BackgroundImageLayout = ImageLayout.Stretch;
            btnTeLimon.FlatAppearance.BorderSize = 0;
            btnTeLimon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnTeLimon.FlatStyle = FlatStyle.Flat;
            btnTeLimon.ForeColor = Color.White;
            btnTeLimon.Image = Properties.Resources.TéDeLimon;
            btnTeLimon.Location = new Point(236, 24);
            btnTeLimon.Margin = new Padding(2);
            btnTeLimon.Name = "btnTeLimon";
            btnTeLimon.Size = new Size(140, 114);
            btnTeLimon.TabIndex = 39;
            btnTeLimon.Text = "Té de Limón";
            btnTeLimon.TextImageRelation = TextImageRelation.TextAboveImage;
            btnTeLimon.UseVisualStyleBackColor = false;
            btnTeLimon.Click += btnTeLimon_Click;
            // 
            // btnLimonada
            // 
            btnLimonada.BackColor = Color.FromArgb(232, 174, 137);
            btnLimonada.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimonada.FlatAppearance.BorderSize = 0;
            btnLimonada.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnLimonada.FlatStyle = FlatStyle.Flat;
            btnLimonada.ForeColor = Color.White;
            btnLimonada.Image = Properties.Resources.Limonada;
            btnLimonada.Location = new Point(44, 189);
            btnLimonada.Margin = new Padding(2);
            btnLimonada.Name = "btnLimonada";
            btnLimonada.Size = new Size(140, 114);
            btnLimonada.TabIndex = 38;
            btnLimonada.Text = "Limonada";
            btnLimonada.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLimonada.UseVisualStyleBackColor = false;
            btnLimonada.Click += btnLimonada_Click;
            // 
            // btnFrapurrccino
            // 
            btnFrapurrccino.BackColor = Color.FromArgb(232, 174, 137);
            btnFrapurrccino.BackgroundImageLayout = ImageLayout.Stretch;
            btnFrapurrccino.FlatAppearance.BorderSize = 0;
            btnFrapurrccino.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnFrapurrccino.FlatStyle = FlatStyle.Flat;
            btnFrapurrccino.ForeColor = Color.White;
            btnFrapurrccino.Image = Properties.Resources.Frapuccino;
            btnFrapurrccino.ImageAlign = ContentAlignment.TopCenter;
            btnFrapurrccino.Location = new Point(44, 24);
            btnFrapurrccino.Margin = new Padding(2);
            btnFrapurrccino.Name = "btnFrapurrccino";
            btnFrapurrccino.Size = new Size(140, 114);
            btnFrapurrccino.TabIndex = 37;
            btnFrapurrccino.Text = "Frapurrccino";
            btnFrapurrccino.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFrapurrccino.UseVisualStyleBackColor = false;
            btnFrapurrccino.Click += btnFrapurrccino_Click;
            // 
            // tpComida
            // 
            tpComida.BackColor = Color.FromArgb(198, 139, 125);
            tpComida.Controls.Add(btnPapas);
            tpComida.Controls.Add(btnRosquillas);
            tpComida.Controls.Add(btnGomitas);
            tpComida.Controls.Add(btnPanini);
            tpComida.Controls.Add(btnTorta);
            tpComida.Controls.Add(btnPanqueque);
            tpComida.Location = new Point(4, 25);
            tpComida.Margin = new Padding(2);
            tpComida.Name = "tpComida";
            tpComida.Padding = new Padding(2);
            tpComida.Size = new Size(615, 341);
            tpComida.TabIndex = 1;
            tpComida.Text = "COMIDA";
            // 
            // btnPapas
            // 
            btnPapas.BackColor = Color.FromArgb(232, 174, 137);
            btnPapas.BackgroundImageLayout = ImageLayout.Stretch;
            btnPapas.Cursor = Cursors.Hand;
            btnPapas.FlatAppearance.BorderSize = 0;
            btnPapas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPapas.FlatStyle = FlatStyle.Flat;
            btnPapas.ForeColor = Color.White;
            btnPapas.Image = Properties.Resources.PapitaFrita;
            btnPapas.Location = new Point(426, 30);
            btnPapas.Margin = new Padding(2);
            btnPapas.Name = "btnPapas";
            btnPapas.Size = new Size(140, 114);
            btnPapas.TabIndex = 48;
            btnPapas.Text = "Papas Fritas";
            btnPapas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPapas.UseVisualStyleBackColor = false;
            btnPapas.Click += btnPapas_Click;
            // 
            // btnRosquillas
            // 
            btnRosquillas.BackColor = Color.FromArgb(232, 174, 137);
            btnRosquillas.BackgroundImageLayout = ImageLayout.Stretch;
            btnRosquillas.Cursor = Cursors.Hand;
            btnRosquillas.FlatAppearance.BorderSize = 0;
            btnRosquillas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRosquillas.FlatStyle = FlatStyle.Flat;
            btnRosquillas.ForeColor = Color.White;
            btnRosquillas.Image = Properties.Resources.RosquillasViejitasSomoteñas;
            btnRosquillas.Location = new Point(426, 192);
            btnRosquillas.Margin = new Padding(2);
            btnRosquillas.Name = "btnRosquillas";
            btnRosquillas.Size = new Size(140, 114);
            btnRosquillas.TabIndex = 47;
            btnRosquillas.Text = "Rosquillas y viejitas";
            btnRosquillas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRosquillas.UseVisualStyleBackColor = false;
            btnRosquillas.Click += btnRosquillas_Click;
            // 
            // btnGomitas
            // 
            btnGomitas.BackColor = Color.FromArgb(232, 174, 137);
            btnGomitas.BackgroundImageLayout = ImageLayout.Stretch;
            btnGomitas.Cursor = Cursors.Hand;
            btnGomitas.FlatAppearance.BorderSize = 0;
            btnGomitas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnGomitas.FlatStyle = FlatStyle.Flat;
            btnGomitas.ForeColor = Color.White;
            btnGomitas.Image = Properties.Resources.GelatinaCafé;
            btnGomitas.Location = new Point(235, 192);
            btnGomitas.Margin = new Padding(2);
            btnGomitas.Name = "btnGomitas";
            btnGomitas.Size = new Size(140, 114);
            btnGomitas.TabIndex = 46;
            btnGomitas.Text = "Gomitas de Café";
            btnGomitas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGomitas.UseVisualStyleBackColor = false;
            btnGomitas.Click += btnGomitas_Click;
            // 
            // btnPanini
            // 
            btnPanini.BackColor = Color.FromArgb(232, 174, 137);
            btnPanini.BackgroundImageLayout = ImageLayout.Stretch;
            btnPanini.Cursor = Cursors.Hand;
            btnPanini.FlatAppearance.BorderSize = 0;
            btnPanini.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPanini.FlatStyle = FlatStyle.Flat;
            btnPanini.ForeColor = Color.White;
            btnPanini.Image = Properties.Resources.PaniniQueso;
            btnPanini.Location = new Point(235, 30);
            btnPanini.Margin = new Padding(2);
            btnPanini.Name = "btnPanini";
            btnPanini.Size = new Size(140, 114);
            btnPanini.TabIndex = 45;
            btnPanini.Text = "Panini de queso";
            btnPanini.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPanini.UseVisualStyleBackColor = false;
            btnPanini.Click += btnPanini_Click;
            // 
            // btnTorta
            // 
            btnTorta.BackColor = Color.FromArgb(232, 174, 137);
            btnTorta.BackgroundImageLayout = ImageLayout.Stretch;
            btnTorta.Cursor = Cursors.Hand;
            btnTorta.FlatAppearance.BorderSize = 0;
            btnTorta.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnTorta.FlatStyle = FlatStyle.Flat;
            btnTorta.ForeColor = Color.White;
            btnTorta.Image = Properties.Resources.SliceTorta;
            btnTorta.Location = new Point(43, 192);
            btnTorta.Margin = new Padding(2);
            btnTorta.Name = "btnTorta";
            btnTorta.Size = new Size(140, 114);
            btnTorta.TabIndex = 44;
            btnTorta.Text = "Slice de Torta Marmoleada";
            btnTorta.TextImageRelation = TextImageRelation.TextAboveImage;
            btnTorta.UseVisualStyleBackColor = false;
            btnTorta.Click += btnTorta_Click;
            // 
            // btnPanqueque
            // 
            btnPanqueque.BackColor = Color.FromArgb(232, 174, 137);
            btnPanqueque.BackgroundImageLayout = ImageLayout.Stretch;
            btnPanqueque.Cursor = Cursors.Hand;
            btnPanqueque.FlatAppearance.BorderSize = 0;
            btnPanqueque.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPanqueque.FlatStyle = FlatStyle.Flat;
            btnPanqueque.ForeColor = Color.White;
            btnPanqueque.Image = Properties.Resources.PanCake;
            btnPanqueque.Location = new Point(43, 30);
            btnPanqueque.Margin = new Padding(2);
            btnPanqueque.Name = "btnPanqueque";
            btnPanqueque.Size = new Size(140, 114);
            btnPanqueque.TabIndex = 43;
            btnPanqueque.Text = "Panqueque";
            btnPanqueque.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPanqueque.UseVisualStyleBackColor = false;
            btnPanqueque.Click += btnPanqueque_Click;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.ColumnHeadersHeight = 45;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.Maroon;
            dgvDatos.Location = new Point(14, 43);
            dgvDatos.Margin = new Padding(1);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Salmon;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            btnMas.Click += btnMas_Click;
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
            btnMenos.Click += btnMenos_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(177, 24);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(202, 27);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Comida o Bebida";
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
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 147, 118);
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(463, 114);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 42);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.Location = new Point(321, 118);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(24, 25);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 12;
            label1.Text = "Código";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCodigo.Location = new Point(117, 24);
            lblCodigo.Margin = new Padding(2, 0, 2, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(24, 27);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "0";
            // 
            // frmCatalogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 214, 180);
            ClientSize = new Size(970, 591);
            Controls.Add(lblCodigo);
            Controls.Add(label1);
            Controls.Add(lblCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantComprar);
            Controls.Add(label2);
            Controls.Add(lblNombre);
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
        private Label lblNombre;
        private Label label2;
        private Label lblCantComprar;
        private Label lblPrecio;
        private PictureBox pictureBox1;
        private Button btnTeCaliente;
        private Button btnCafeCaliente;
        private Button btnCafeHelado;
        private Button btnTeLimon;
        private Button btnLimonada;
        private Button btnFrapurrccino;
        private Button btnPapas;
        private Button btnRosquillas;
        private Button btnGomitas;
        private Button btnPanini;
        private Button btnTorta;
        private Button btnPanqueque;
        private System.Drawing.Printing.PrintDocument ImprimirFactura;
        private Button btnAgregar;
        private Label lblCantidad;
        private Label label1;
        private Label lblCodigo;
    }
}