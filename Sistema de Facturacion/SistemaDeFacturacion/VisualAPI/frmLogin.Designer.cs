namespace VisualWebAPI
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnIngresar = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnOcultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gatito;
            pictureBox1.Location = new Point(69, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Jumbox", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 68, 68);
            label1.Location = new Point(106, 234);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 1;
            label1.Text = "Inicio Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Usuario;
            pictureBox2.Location = new Point(44, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Lock;
            pictureBox3.Location = new Point(44, 379);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(80, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 5);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(80, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 5);
            panel2.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 92, 92);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 146, 146);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 146, 146);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Boldena", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(44, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(224, 92, 92);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 146, 146);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 146, 146);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Boldena", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(245, 530);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(105, 39);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(248, 199, 169);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Boldena", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(218, 68, 68);
            txtUser.Location = new Point(80, 319);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(270, 20);
            txtUser.TabIndex = 8;
            txtUser.Text = "Usuario";
            txtUser.Click += txtUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 199, 169);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Boldena", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(218, 68, 68);
            txtPassword.Location = new Point(80, 383);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 20);
            txtPassword.TabIndex = 9;
            txtPassword.Text = "Contraseña";
            txtPassword.Click += txtPassword_Click;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnOcultar
            // 
            btnOcultar.Image = Properties.Resources.Ojo;
            btnOcultar.Location = new Point(325, 379);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(25, 25);
            btnOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            btnOcultar.TabIndex = 10;
            btnOcultar.TabStop = false;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 199, 169);
            ClientSize = new Size(406, 610);
            Controls.Add(btnOcultar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnIngresar);
            Controls.Add(btnCancelar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button btnCancelar;
        private Button btnIngresar;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox btnOcultar;
    }
}