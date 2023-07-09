using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWebAPI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //[ Esto es para que se pueda mover nuestro formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FrmInicioMenu_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmInitiation());
        }

        private void brTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = (Form)FormHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            MenuVertical.Text = fh.Text;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistoryMenu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmHistory());
        }

        private void btnInformationMenu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmInformation());
        }
    }
}
