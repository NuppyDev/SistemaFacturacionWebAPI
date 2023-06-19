using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controler.Dto;

namespace Controler.Controladores
{
    public class ControlHistorical
    {
        //Se declara un controlfacturas para usar la tarea de obtener todas las facturas
        ControlFacturas cf = new ControlFacturas();

        //Tarea que se utiliza en el visual donde se juntan las listas de factura y historico para obtener solamente
        //datos relevantes (ids, fecha factura, cliente y mesa) para mostrar en el visual con datagridview
        public async Task ObtencionFacturas(DataGridView dgvDatos)
        {
            List<HistoricalDto> h = await ObtenerHistorial();
            List<InvoiceDto> i = await cf.ObtenerFacturas();
            var juntacion = i.Join(
                            h,
                            facturas => facturas.InvoiceId,
                            historical => historical.InvoiceId,
                            (facturas, historical)=> new
                            {
                                IdHistorial = historical.HistoricalId,
                                IdFactura = historical.InvoiceId,
                                FechaFactura = facturas.CreatedDate,
                                ClienteFactura = facturas.Customer,
                                MesasFactura = facturas.TableId
                            }).ToList();
            dgvDatos.DataSource =null;
            dgvDatos.DataSource = juntacion;
        }

        //Esta devuelve todos los datos historicos que hay
        private async Task<List<HistoricalDto>> ObtenerHistorial()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7051/api/Historical"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var Historico = await response.Content.ReadAsStringAsync();
                        var datos = JsonConvert.DeserializeObject<List<HistoricalDto>>(Historico);
                        return datos.ToList();
                    }
                    else
                    {
                        MessageBox.Show("La paquetería de datos se ha perdido, los datos de historicos no serán entregados a tiempo", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
        }
        //Es utilizado para la vista para crear un historial solamente con el numero de factura
        public async Task CrearHistorial(int idFactura)
        {
            HistoricalCreateDto i = new HistoricalCreateDto();
            i.InvoiceId = idFactura;
            await CrearHistorico(i);
        }
        //Tarea que crea un historico con un parametro de HistoricalCreateDto
        private async Task CrearHistorico(HistoricalCreateDto idd)
        {
            using (var client = new HttpClient())
            {
                var seriHis = JsonConvert.SerializeObject(idd);
                var content = new StringContent(seriHis, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7051/api/Historical", content);
                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"Error al meowguardar la union: {response.Content.ReadAsStringAsync().Result}", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
