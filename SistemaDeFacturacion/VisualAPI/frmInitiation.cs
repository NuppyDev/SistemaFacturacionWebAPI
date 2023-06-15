using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace VisualWebAPI
{
    public partial class frmInitiation : Form
    {
        public frmInitiation()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int id = 7;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            int id = 1;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            int id = 4;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            int id = 3;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            int id = 6;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            int id =5;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            int id = 2;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            //frmCatalogue.StartPosition = FormStartPosition.Manual;
            //frmCatalogue.Left = 1386;
            //frmCatalogue.Top = 985;
            frmCatalogue.ShowDialog(); //Muestra el formulario
            //frmCatalogue.Location = new Point(192, 39);   // (x,y)
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
        }
    }
}
