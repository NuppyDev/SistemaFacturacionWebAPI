using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controler.Dto;
namespace Controler.Controladores
{
    public class ControlDescripcion
    {
        public DescriptionCreateDto d;
        public async void CrearDescription(int idFactura, int idProducto, int cant, decimal precio)
        {
            decimal subtotal = cant * precio;
            decimal iva = Convert.ToDecimal(1.15);
            decimal total = subtotal* iva;
            DescriptionCreateDto des = new DescriptionCreateDto();
            des.InvoiceId = idFactura;
            des.ProductsId = idProducto;
            des.Cant = cant;
            des.UnitePrice = precio;
            des.SubTotal = subtotal;
            des.Total = total;
            await CrearDescripcion(des);
        }

        public async Task<List<int>> ObtenerId(int numfact)
        {
            List<int> id = await ObtenerIdDescription(numfact);
            return id;
        }
        private async Task CrearDescripcion(DescriptionCreateDto des)
        {
            using (var client = new HttpClient())
            {
                var seriDescri = JsonConvert.SerializeObject(des);
                var content = new StringContent(seriDescri, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/Description", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al guardar la descripcion: {response.Content.ReadAsStringAsync().Result}");
            }
        }
        private async Task<List<int>> ObtenerIdDescription(int numFact)
        {
            List<int> resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    List<int> f;
                    var response = await client.GetAsync("https://localhost:7051/api/Description");
                    if (response.IsSuccessStatusCode)
                    {
                        var des = await response.Content.ReadAsStringAsync();
                        var desc = JsonConvert.DeserializeObject<List<DescriptionDto>>(des);
                        f = desc.Where(x=>x.InvoiceId==numFact).OrderByDescending(x => x.DescriptionId).Select(x=>x.DescriptionId).ToList();
                        return f;
                    }
                    else
                    {
                        return f=null!;
                    }
                });
            }
            return resultado;
        }
    }
}
