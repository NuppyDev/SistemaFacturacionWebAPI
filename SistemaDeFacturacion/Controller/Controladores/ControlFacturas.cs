using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Dto.Create;

namespace Controler.Controladores
{
    public class ControlFacturas
    {
        private async void CrearFactura(int idHistorical, int idMesa, int idMesero, DateTime dt, string cliente)
        {
            cliente = "Cliente Casual";
            InvoiceCreateDto factu = new InvoiceCreateDto();
            factu.HistoricalId = idHistorical;
            factu.TableId = idMesa;
            factu.WaitersId = idMesero;
            factu.CreatedDate = dt;
            factu.Customer = cliente;

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
