using System;
using System.ComponentModel.DataAnnotations;

namespace VisualWebAPI
{
    public class descri
    {
        public descri(int productsId, int cant, string nombre, double unitePrice, double subTotal, double total)
        {
            Cod = productsId;
            Cantidad = cant;
            Producto = nombre;
            PrecioUnitario = unitePrice;
            SubTotal = subTotal;
            Total = total;
        }
        public int Cod { get; set; }
        public int Cantidad { get; set; }
        public string Producto { get; set; }
        public double PrecioUnitario { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
    }
}