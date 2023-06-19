using Controler.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWebAPI
{
    public partial class frmHistory : Form
    {
        //Declarar e inicializar variable para usar su metodo de obtencion de Facturas
        ControlHistorical ch = new ControlHistorical();
        public frmHistory()
        {
            InitializeComponent();
            //Cada vez que se precione, se llene o actualice el datagridview con info que entra
            Llenado();
        }

        //Llena el datagridview del metodo de obtencion de factura
        public async void Llenado()
        {
            await ch.ObtencionFacturas(dgvDatos);
        }
    }
}
