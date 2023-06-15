using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Dto.Create;
namespace Controler.Controladores
{
    public class ControlDescripcion
    {
        public List<DescriptionCreateDto> Creacion = new List<DescriptionCreateDto>();
        public async Task LLenarListaDescripcion(DescriptionCreateDto d)
        {
            Creacion.Add(d);
        }
        public async void EnviarListaDescripcion()
        {
            foreach (DescriptionCreateDto dto in Creacion)
                CrearDescripcion(dto.InvoiceId, dto.ProductsId, dto.Cant, dto.UnitePrice);
        }
        private async void CrearDescripcion(int idFactura, int idProducto, int cant, decimal precio)
        {
            decimal subtotal = cant * precio;
            decimal iva = Convert.ToDecimal(1.15);
            DescriptionCreateDto des = new DescriptionCreateDto();
            des.InvoiceId = idFactura;
            des.ProductsId = idProducto;
            des.Cant = cant;
            des.UnitePrice = precio;
            des.SubTotal = subtotal;
            des.Total = subtotal * iva;

            using (var client = new HttpClient())
            {
                var seriDescri = JsonConvert.SerializeObject(des);
                var content = new StringContent(seriDescri, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/Description", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al guardar la descripcion: {response.Content.ReadAsStringAsync().Result}");
            }

        }
    }
}
