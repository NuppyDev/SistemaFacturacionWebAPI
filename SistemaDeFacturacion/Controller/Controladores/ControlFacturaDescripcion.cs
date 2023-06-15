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
        public List<InvoiceDescriptionCreateDto> Creacion = new List<InvoiceDescriptionCreateDto>();
        public async Task LLenarListaInDe(InvoiceDescriptionCreateDto d)
        {
            Creacion.Add(d);
        }
        public async void EnviarListaInDe()
        {
            foreach (InvoiceDescriptionCreateDto dto in Creacion)
                CrearDescripcionFactura(dto.InvoiceId, dto.DescriptionId);
        }
        private async void CrearDescripcionFactura(int idFactura, int idDescripcion)
        {
            InvoiceDescriptionCreateDto i = new InvoiceDescriptionCreateDto();
            i.DescriptionId = idDescripcion;
            i.InvoiceId = idFactura;

            using (var client = new HttpClient())
            {
                var seriDesFac = JsonConvert.SerializeObject(i);
                var content = new StringContent(seriDesFac, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/InvoiceDescription", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al guardar la union: {response.Content.ReadAsStringAsync().Result}");
            }

        }
    }
}
