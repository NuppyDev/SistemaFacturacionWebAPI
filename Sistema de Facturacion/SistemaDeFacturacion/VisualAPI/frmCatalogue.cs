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
using Controler.Dto;

namespace VisualWebAPI
{
    public partial class frmCatalogue : Form
    {
        #region Inicializacion de Variables
        public const string PathImageLogo = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\Gatito.png";
        public const string PathImageDespedida = @"C:\Users\Usuario\GitHub Repositorios\SistemaFacturacionWebAPI\SistemaDeFacturacion\VisualAPI\Resources\GatitoDespedida.png";
        public int IdMesa, idProducto, cant, numerofactura = 0;
        List<string> listaProducto;
        MesasYMeseros mm = new MesasYMeseros();
        List<int> idDescripciones = new List<int>(), idproductos = new List<int>();
        List<descri> descrip = new List<descri>();
        FuncionImprimir imprimir = new FuncionImprimir();
        descri descri;
        DateTime dt = new DateTime();
        ControlMesas cm = new ControlMesas(); ControlCatalogo cc = new ControlCatalogo();
        ControlDescripcion cd = new ControlDescripcion(); ControlFacturas cf = new ControlFacturas();
        ControlFacturaDescripcion cfd = new ControlFacturaDescripcion(); ControlHistorical ch = new ControlHistorical();
        #endregion
        public frmCatalogue(int idMesa)
        {
            InitializeComponent();
            this.IdMesa = idMesa;
            LlenadoListaMesas(IdMesa);
            //ObtenerUltimaFactura();
            numerofactura++;
            dt = DateTime.Now;
        }

        #region BotonesFuncionalesBasicos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpieza();
            this.Close();
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            lblMesa.Text = mm.IdMesas.ToString();
            lblMesero.Text = mm.NameMeseros;
            lblIdMesero.Text = mm.IdMeseros.ToString();
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
                MessageBox.Show("No creo que vendamos negativas cantidades... ¿O si?", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region FuncionesLlenadoObtencionCreacionEnviado
        public async void LlenadoListaMesas(int id)
        {
            mm = await cm.ObtenerMesasYMeserosAsync(id);
        }
        public async Task LlenadoListaProductos(int e)
        {
            listaProducto = await cc.Productos(e);
        }
        public async void ObtenerUltimaFactura()
        {
            numerofactura = await cf.ObtenerUltimaFacturas();
        }
        public async Task ObtenerIdDescripciones()
        {
            idDescripciones = await cd.ObtenerId(numerofactura);
        }
        public async Task LlenadoFactura()
        {
            await cf.CrearFacturas(mm.IdMesas, mm.IdMeseros, dt);
        }
        public async Task CrearINDE()
        {
            foreach (int i in idDescripciones)
                await cfd.CrearInDe(numerofactura, i);
        }
        public async void CrearHistorial()
        {
            await ch.CrearHistorial(numerofactura);
        }
        public async Task EnvioDeDatos()
        {
            await ObtenerIdDescripciones();
            await LlenadoFactura();
            await CrearINDE();
            CrearHistorial();
        }
        #endregion

        #region Funciones
        public void Limpieza()
        {
            IdMesa = 0; idProducto = 0; numerofactura--;
            dgvDatos.DataSource = null; cant = 0;
            descrip.Clear();
        }
        public void LimpiezaDatos()
        {
            lblCantidad.Text = "0";
            lblCodigo.Text = "0";
            lblPrecio.Text = "00.00";
            lblNombre.Text = "Comida o Bebida";
            cant = 0;
        }
        public void obtenerTotal()
        {
            double costo = 0;
            int contador = 0;
            contador = dgvDatos.RowCount;
            for (int i = 0; i < contador; i++)
            {
                costo += double.Parse(dgvDatos.Rows[i].Cells[5].Value.ToString());
            }

            lblTotal.Text = costo.ToString();
        }

        public void obtenerSubTotal()
        {
            double costo = 0;
            int contador = 0;
            contador = dgvDatos.RowCount;
            for (int i = 0; i < contador; i++)
            {
                costo += double.Parse(dgvDatos.Rows[i].Cells[4].Value.ToString());
            }
            lblSubTotal.Text = costo.ToString();
        }

        #endregion

        #region Imprimir
        private void Imprimir()
        {
            imprimir.Imprimir(dgvDatos, numerofactura, mm.NameMeseros, mm.IdMesas, lblSubTotal.Text, lblTotal.Text);
        }
        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            await EnvioDeDatos();
            Imprimir();
            Limpieza();
            this.Close();
        }
        #endregion

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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblCantidad.Text != "0" && lblCodigo.Text != "0" &&
                lblPrecio.Text != "00.00" && lblNombre.Text != "Comida o Bebida")
            {
                if (lblCantidad.Text != "0")
                {
                    await cd.CrearDescription(numerofactura, Convert.ToInt32(lblCodigo.Text), Convert.ToInt32(lblCantidad.Text), Convert.ToDecimal(lblPrecio.Text));
                    int co = Convert.ToInt32(lblCodigo.Text);
                    int ca = Convert.ToInt32(lblCantidad.Text);
                    string nom = lblNombre.Text;
                    double pre = Convert.ToDouble(lblPrecio.Text);
                    double sub = ca * pre;
                    double to = sub * Convert.ToDouble(1.15);
                    descri = new descri(co, ca, nom, pre, sub, to);
                    idproductos.Add(co);
                    descrip.Add(descri);
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = descrip;
                    obtenerSubTotal();
                    obtenerTotal();
                    LimpiezaDatos();
                }
                else
                {
                    MessageBox.Show("¿El cliente está comprando o no este producto?", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¿Se puede crear una factura sin productos?", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmCatalogue_Load(object sender, EventArgs e)
        {
        }

        private void tcMenu_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}