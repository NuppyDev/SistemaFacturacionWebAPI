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
        int id = 0;
        public frmInitiation()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 7
            id = 7;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 1
            id = 1;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 4
            id = 4;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 3
            id = 3;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 6
            id = 6;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 5
            id = 5;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            //Id de la mesa es 2
            id = 2;
            //Generamos la instancia hacia el frmInitiation
            frmCatalogue frmCatalogue = new frmCatalogue(id);
            this.Hide(); //Oculta el formulario actual
            frmCatalogue.ShowDialog(); //Muestra el formulario
            frmCatalogue.Dock = DockStyle.Fill;
            this.Show(); //Muestrael formulario actual
            //Id se vacia por si se cambia de mesa
            id = 0;
        }
    }
}
