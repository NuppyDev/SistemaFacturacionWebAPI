using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Dto.Create;

namespace Controler.Controladores
{
    public class ControlFacturaDescripcion
    {
        public async Task CrearInDe(int idFactura, int idDescripcion)
        {
            InvoiceDescriptionCreateDto i = new InvoiceDescriptionCreateDto();
            i.DescriptionId = idDescripcion;
            i.InvoiceId = idFactura;
            await CrearDescripcionFactura(i);
        }
        private async Task CrearDescripcionFactura(InvoiceDescriptionCreateDto idd)
        {
            using (var client = new HttpClient())
            {
                var seriDesFac = JsonConvert.SerializeObject(idd);
                var content = new StringContent(seriDesFac, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/InvoiceDescription", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al guardar la union: DescricionFactura {response.Content.ReadAsStringAsync().Result}", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
