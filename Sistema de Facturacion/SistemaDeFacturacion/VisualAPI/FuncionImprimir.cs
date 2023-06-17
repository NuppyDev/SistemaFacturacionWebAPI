using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler;

namespace VisualWebAPI
{
    public class FuncionImprimir
    {
        clsFunciones clsFunciones;
        public void Imprimir(DataGridView dgvDatos, int numFactura, string mesero, int mesa, string sub, string to)
        {
            double subtotal = Convert.ToDouble(sub);
            double total = Convert.ToDouble(to);
            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

            Ticket1.TextoCentro("Empresa Mansión Meow Meow"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:" + numFactura.ToString());
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Mesa: " + mesa);
            Ticket1.TextoIzquierda("Le Atendio: "+mesero);
            Ticket1.TextoIzquierda("");
            clsFunciones.CreaTicket.LineasGuion();

            clsFunciones.CreaTicket.EncabezadoVenta();
            clsFunciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvDatos.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[2].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[1].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFunciones.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("SUBTOTAL", subtotal); // imprime linea con Subtotal
            Ticket1.AgregaTotalesN("Más IVA", "15%"); // imprime linea con ITBis total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", total); // imprime linea con total
            Ticket1.TextoIzquierda(" ");


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);
            MessageBox.Show("Gracias por preferirnos", "MeowSystem Imprimiendo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
