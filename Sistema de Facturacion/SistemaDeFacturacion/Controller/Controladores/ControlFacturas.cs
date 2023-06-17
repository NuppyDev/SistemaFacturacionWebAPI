using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Dto.Base;
using WebAPI.Models.Dto.Create;

namespace Controler.Controladores
{
    public class ControlFacturas
    {
        public async Task<int> ObtenerUltimaFacturas()
        {
            int lastFac = await ObtenerUltimaFactura();
            return lastFac;
        }
        private async Task<int> ObtenerUltimaFactura()
        {
            int resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    int t;
                    var response = await client.GetAsync("https://localhost:7051/api/Invoice");
                    if (response.IsSuccessStatusCode)
                    {
                        var factu = await response.Content.ReadAsStringAsync();
                        var fac = JsonConvert.DeserializeObject<List<InvoiceDto>>(factu);
                        InvoiceDto f = fac.OrderByDescending(x=>x.InvoiceId).FirstOrDefault();
                        t =0;
                        return t;
                    }
                    else
                    {
                        return t = 0;
                    }
                });
            }
            return resultado;
        }
        public async Task CrearFacturas(int idMesa, int idMesero, DateTime dt)
        {
            InvoiceCreateDto factu = new InvoiceCreateDto();
            factu.TableId = idMesa;
            factu.WaitersId = idMesero;
            factu.CreatedDate = dt;
            factu.Customer = "Cliente Casual";
            await CrearFactura(factu);
        }
        private async Task CrearFactura(InvoiceCreateDto factu)
        {
            using (var client = new HttpClient())
            {
                var seriFactu = JsonConvert.SerializeObject(factu);
                var content = new StringContent(seriFactu, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/Invoice", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al guardar la factura: {response.Content.ReadAsStringAsync().Result}");
            }

        }
    }
}
