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
            //Al recibir el ideMesa se la llena a la varibale IdMesa para su uso en este formulario
            this.IdMesa = idMesa;
            //Este metodo se hace cada vez que se muestre este formulario
            LlenadoListaMesas(IdMesa);
            //Metodo que cada vez que se muestre este formulario obtener el ultima factura hecha para
            //solamente sumarle uno y ser usado
            dt = DateTime.Now;
        }

        #region BotonesFuncionalesBasicos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cuando la persona le de a cancelar, se haga el metodo de limpieza y que se cierre el formulario
            Limpieza();
            this.Close();
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            //Este boton hace que se muestre la cantidad que se va a comprar por medio de un boton que
            //aumenta cada vez que es precionado
            //Tambien muestra la info de los meseros
            lblMesa.Text = mm.IdMesas.ToString();
            lblMesero.Text = mm.NameMeseros;
            lblIdMesero.Text = mm.IdMeseros.ToString();
            cant++;
            lblCantidad.Text = cant.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //Este boton hace que se muestre la cantidad que se va a comprar por medio de un boton que
            //reduce cada vez que es precionado
            if (cant > 0)
            {
                //Si la cantidad que antes era mayor que cero, se reduce
                cant--;
                lblCantidad.Text = cant.ToString();
            }
            else
            {
                //Si no, se muestra que no puede seguir reduciendo
                cant = 0;
                lblCantidad.Text = cant.ToString();
                MessageBox.Show("No creo que vendamos negativas cantidades... ¿O si?", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region FuncionesLlenadoObtencionCreacionEnviado
        public async void LlenadoListaMesas(int id)
        {
            //Metodo para guardar los datos de los meseros en una variable de este formulario
            mm = await cm.ObtenerMesasYMeserosAsync(id);
        }
        public async Task LlenadoListaProductos(int id)
        {
            //Metodo para guardar los datos de los productos en una variable coleccionable de este formulario
            listaProducto = await cc.Productos(id);
        }
        public async Task ObtenerUltimaFactura()
        {
            //Metodo para guardar los datos de la ultima factura registrada en una variable de este formulario
            numerofactura = await cf.ObtenerUltimaFacturas();
        }
        public async Task ObtenerIdDescripciones()
        {
            //Metodo para guardar los datos de las id de las descripciones en una variable coleccionable de este formulario
            idDescripciones = await cd.ObtenerId(numerofactura);
        }
        public async Task LlenadoFactura()
        {
            //Metodo que crea una factura y la envia a la base de datos
            await cf.CrearFacturas(mm.IdMesas, mm.IdMeseros, dt);
        }
        public async Task CrearINDE()
        {
            //Metodo que crea una facturaDescripcion y la envia a la base de datos

            //Se usa un foreach ya que las id de descripciones guardadas son muchas y todas a un solo numero de factura
            foreach (int i in idDescripciones)
                await cfd.CrearInDe(numerofactura, i);
        }
        public async void CrearHistorial()
        {
            //Metodo que crea un historial solamente con el numero de factura
            await ch.CrearHistorial(numerofactura);
        }
        public async Task EnvioDeDatos()
        {
            //Metodo que reune a todos los metodos de enviados de datos
            await ObtenerIdDescripciones();
            await LlenadoFactura();
            await CrearINDE();
            CrearHistorial();
        }
        #endregion

        #region Funciones
        public void Limpieza()
        {
            //Limpieza de las variables y obtejos
            IdMesa = 0; idProducto = 0; numerofactura--;
            dgvDatos.DataSource = null; cant = 0;
            descrip.Clear();
        }
        public void LimpiezaDatos()
        {
            //Volver al estado original de los labels a sus datos predeterminado
            lblCantidad.Text = "0";
            lblCodigo.Text = "0";
            lblPrecio.Text = "00.00";
            lblNombre.Text = "Comida o Bebida";
            cant = 0;
        }
        public void obtenerTotal()
        {
            //Obtener el total de toda la columna de totales del datagridview
            double costo = 0;
            int contador = 0;
            contador = dgvDatos.RowCount;
            for (int i = 0; i < contador; i++)
            {
                costo += double.Parse(dgvDatos.Rows[i].Cells[5].Value.ToString());
            }
            //para presentarla en un label
            lblTotal.Text = costo.ToString();
        }

        public void obtenerSubTotal()
        {
            //Obtener el subtotal de toda la columna de totales del datagridview
            double costo = 0;
            int contador = 0;
            contador = dgvDatos.RowCount;
            for (int i = 0; i < contador; i++)
            {
                costo += double.Parse(dgvDatos.Rows[i].Cells[4].Value.ToString());
            }
            //para presentarla en un label
            lblSubTotal.Text = costo.ToString();
        }

        #endregion

        #region Imprimir
        private void Imprimir()
        {
            //Metodo para poder imprimir la factura
            imprimir.Imprimir(dgvDatos, numerofactura, mm.NameMeseros, mm.IdMesas, lblSubTotal.Text, lblTotal.Text);
        }
        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            //Al darle clic a este boton, aumenta el numero de factura, se envian los datos a la api
            //se imprime la factura,
            //se limpia todo y se cierra
            if (lblTotal.Text != "0.00")
            {
                await EnvioDeDatos();
                Imprimir();
                Limpieza();
                this.Close();
            }
            else
            {
                MessageBox.Show("¿Imprimir factura sin datos? Escoge las opciones purr favor", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            //Se espera que ningun dato esté sin elegir
            if (lblCantidad.Text != "0" && lblCodigo.Text != "0" &&
                lblPrecio.Text != "00.00" && lblNombre.Text != "Comida o Bebida")
            {
                //Por si al usuario se le olvidó digitar la cantidad
                if (lblCantidad.Text != "0")
                {
                    //Se crea la descripcion y se envia la web api
                    await cd.CrearDescription(numerofactura, Convert.ToInt32(lblCodigo.Text), Convert.ToInt32(lblCantidad.Text), Convert.ToDecimal(lblPrecio.Text));
                    //Se declara e inicializan variables locales para llenar el datagridview y las facturas
                    int co = Convert.ToInt32(lblCodigo.Text);
                    int ca = Convert.ToInt32(lblCantidad.Text);
                    string nom = lblNombre.Text;
                    double pre = Convert.ToDouble(lblPrecio.Text);
                    double sub = ca * pre;
                    double to = sub * Convert.ToDouble(1.15);
                    descri = new descri(co, ca, nom, pre, sub, to);
                    //Se llena la lista de id productos con co
                    idproductos.Add(co);
                    //Se llena la lista de descripciones con el objeto descri
                    descrip.Add(descri);
                    //Para que el data grid view muestre los datos
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = descrip;
                    //Obtener subtotales y totales
                    obtenerSubTotal();
                    obtenerTotal();
                    //Que se limpien los datos
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
            await ObtenerUltimaFactura();
            numerofactura++;
        }

        private void tcMenu_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}