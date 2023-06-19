using Azure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controler.Dto;

namespace Controler.Controladores
{
    public class ControlFacturas
    {
        //Es utilizado por la vista para obtener la ultima factura para agregarle uno y asi para los nuevos registros
        //que necesitan el numero de factura
        public async Task<int> ObtenerUltimaFacturas()
        {
            int lastFac = await ObtenerUltimaFactura();
            return lastFac;
        }
        //Es utilizado para la vista para que retorne todas las facturas
        public async Task<List<InvoiceDto>> ObtenerFacturas()
        {
            List<InvoiceDto> list = await ObtenerFactura();
            return list;
        }

        //Esta lista retorna un entero que es el id de la ultima factura registrada
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
                        t =f.InvoiceId;
                        return t;
                    }
                    else
                    {
                        MessageBox.Show("La paquetería de datos se ha perdido, los datos de facturas no serán entregados a tiempo", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return t = 0;
                    }
                });
            }
            return resultado;
        }

        //Esta tarea obtiene una lista de facturas
        private async Task<List<InvoiceDto>> ObtenerFactura()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7051/api/Invoice"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var Factura = await response.Content.ReadAsStringAsync();
                        var datos = JsonConvert.DeserializeObject<List<InvoiceDto>>(Factura);
                        return datos.ToList();
                    }
                    else
                    {
                        MessageBox.Show("La paquetería de datos se ha perdido, los datos de facturas no serán entregados a tiempo", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }

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
                    MessageBox.Show($"Error al meowguardar la factura: {response.Content.ReadAsStringAsync().Result}","Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
