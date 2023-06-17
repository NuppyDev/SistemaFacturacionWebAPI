using Controler.Dto;
using Newtonsoft.Json;
using System.Text;
using Controler.Dto;

namespace Controler.Controladores
{
    public class ControlMesas
    {
        int t;
        string m;
        public async Task<MesasYMeseros> ObtenerMesasYMeserosAsync(int id)
        {
            MesasYMeseros mm = new MesasYMeseros();
            int numeroMesa = await ObtenerIdMesas(id);
            int idMesero = await ObtenerMeserosConIdMesas(id);
            string nombreMesero = await ObtenerNombreMeseros(idMesero);
            mm.IdMesas = numeroMesa;
            mm.NameMeseros = nombreMesero;
            mm.IdMeseros = idMesero;
            return mm;
        }

        private async Task<int> ObtenerIdMesas(int id)
        {
            int resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    var response = await client.GetAsync(string.Format("{0}/{1}", "https://localhost:7051/api/Tables", id));
                    if (response.IsSuccessStatusCode)
                    {
                        var tables = await response.Content.ReadAsStringAsync();
                        TablesDto mesa = JsonConvert.DeserializeObject<TablesDto>(tables);
                        t = mesa.TableId;
                        return t;
                    }
                    else
                    {
                        return 0;
                    }
                });
            }
            return resultado;
        }
        private async Task<int> ObtenerMeserosConIdMesas(int id)
        {
            int resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    var response = await client.GetAsync(string.Format("{0}/{1}", "https://localhost:7051/api/Tables", id));
                    if (response.IsSuccessStatusCode)
                    {
                        var tables = await response.Content.ReadAsStringAsync();
                        TablesDto mesa = JsonConvert.DeserializeObject<TablesDto>(tables);
                        t = mesa.WaitersId;
                        return t;
                    }
                    else
                    {
                        return 0;
                    }
                });
            }
            return resultado;
        }
        private async Task<string> ObtenerNombreMeseros(int id)
        {
            string mesero;
            using (var client = new HttpClient())
            {
                mesero = await Task.Run(async () =>
                {
                    using (var response = await client.GetAsync("https://localhost:7051/api/Waiters"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var waiters = await response.Content.ReadAsStringAsync();
                            List<WaitersDto> mese = JsonConvert.DeserializeObject<List<WaitersDto>>(waiters);
                            var me = mese.Where(x => x.WaitersId == id).FirstOrDefault();
                            m = me.WaitersFullName;
                            return m;

                        }
                        else
                        {
                            return "";
                        }
                    }
                });
            }
            return mesero;
        }
    }
}