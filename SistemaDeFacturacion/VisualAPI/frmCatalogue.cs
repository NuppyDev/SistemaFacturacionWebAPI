using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler.Controladores;

namespace VisualWebAPI
{
    public partial class frmCatalogue : Form
    {
        #region Inicializacion de Variables
        public const string PathImageLogo = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\Gatito.png";
        public const string PathImageDespedida = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\GatitoDespedida.png";
        public int idMesa, idProducto, cant;
        List<string> listaMesas, listaProducto;
        ControlMesas cm = new ControlMesas();
        ControlCatalogo cc = new ControlCatalogo();
        ControlDescripcion cd = new ControlDescripcion();
        ControlFacturas cf = new ControlFacturas();
        ControlFacturaDescripcion cfd = new ControlFacturaDescripcion();
        #endregion
        public frmCatalogue(int idMesa)
        {
            InitializeComponent();
            this.idMesa = idMesa;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idMesa = 0; idProducto = 0;
            this.Close();
        }

        public async Task LlenadoListaMesas()
        {
            listaMesas = await cm.ObtenerMesasYMeserosAsync(idMesa);
            //await LlenadoListaMesas();
            //lblNombre.Text = listaMesas[1];

        }
        public async Task LlenadoListaProductos(int e)
        {
            listaProducto = await cc.Productos(e);
        }

        #region Imprimir
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(PathImageLogo);
            Image despedida = Image.FromFile(PathImageDespedida);
            Font FuenteNormal = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            Font FuenteNegritas = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font FuenteCursiva = new Font("Arial", 12, FontStyle.Italic, GraphicsUnit.Point);
            int y = 20;
            e.Graphics.DrawImage(logo, new Rectangle(0, y += 30, 30, 30));
            e.Graphics.DrawString("Un ticket feliz", FuenteNormal, Brushes.Black, new RectangleF(0, y += 10, 120, 20));
            e.Graphics.DrawImage(despedida, new Rectangle(0, y += 30, 30, 30));
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirFactura = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ImprimirFactura.PrinterSettings = ps;
            ImprimirFactura.PrintPage += Imprimir;
            ImprimirFactura.Print();
        }
        #endregion


        private void btnMas_Click(object sender, EventArgs e)
        {
            cant++;
            lblCantidad.Text = cant.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (cant > 0)
            {
                cant--;
                lblCantidad.Text = cant.ToString();
            }
            else
            {
                cant = 0;
                lblCantidad.Text = cant.ToString();
                MessageBox.Show("¿No creo que vendamos negativas cantidades?", "Gatito Triste 😿");
            }

        }
        #region BotonesDeProductsQueSoloDanID
        private async void btnFrapurrccino_Click(object sender, EventArgs e)
        {
            idProducto = 3;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnTeLimon_Click(object sender, EventArgs e)
        {
            idProducto = 4;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnTeCaliente_Click(object sender, EventArgs e)
        {
            idProducto = 6;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnLimonada_Click(object sender, EventArgs e)
        {
            idProducto = 5;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnCafeHelado_Click(object sender, EventArgs e)
        {
            idProducto = 2;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnCafeCaliente_Click(object sender, EventArgs e)
        {
            idProducto = 1;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }
        private async void btnPapas_Click(object sender, EventArgs e)
        {
            idProducto = 12;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnRosquillas_Click(object sender, EventArgs e)
        {
            idProducto = 7;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnGomitas_Click(object sender, EventArgs e)
        {
            idProducto = 11;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnPanini_Click(object sender, EventArgs e)
        {
            idProducto = 8;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnTorta_Click(object sender, EventArgs e)
        {
            idProducto = 10;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }

        private async void btnPanqueque_Click(object sender, EventArgs e)
        {
            idProducto = 9;
            await LlenadoListaProductos(idProducto);
            lblCodigo.Text = listaProducto[0];
            lblNombre.Text = listaProducto[1];
            lblPrecio.Text = listaProducto[2];
        }
        #endregion

    }
}
