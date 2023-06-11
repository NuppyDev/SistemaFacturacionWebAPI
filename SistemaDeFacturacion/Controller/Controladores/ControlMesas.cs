using Newtonsoft.Json;
using System.Text;
using WebAPI.Models.Dto.Base;

namespace Controller.Controladores
{
    public class ControlMesas
    {
        List<string> MesasYMeseros = new List<string>();
        int t;
        string m;

        public async Task<List<string>> ObtenerMesasYMeserosAsync(int id)
        {
            int numeroMesa = await ObtenerMesas(id);
            string numeroMesas = Convert.ToString(numeroMesa);
            string nombreMesero = await ObtenerMeseros(numeroMesa);
            MesasYMeseros.Add(numeroMesas);
            MesasYMeseros.Add(nombreMesero);
            return MesasYMeseros;
        }

        private async Task<int> ObtenerMesas(int id)
        {
            int resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    var response = await client.GetAsync(string.Format("{0}/{1}", "https://localhost:7051/api/Tables", id));
                    if (response.IsSuccessStatusCode)
                    {
                        int t;
                        var tables = await response.Content.ReadAsStringAsync();
                        TablesDto mesa = JsonConvert.DeserializeObject<TablesDto>(tables);
                        t = mesa.TableId;
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
        private async Task<string> ObtenerMeseros(int id)
        {
            string mesero;
            using (var client = new HttpClient())
            {
                mesero = await Task.Run(async () =>
                {
                    var response = await client.GetAsync(string.Format("{0}/{1}", "https://localhost:7051/api/Waiters", id));
                    if (response.IsSuccessStatusCode)
                    {
                        string m;
                        var waiters = await response.Content.ReadAsStringAsync();
                        WaitersDto mese = JsonConvert.DeserializeObject<WaitersDto>(waiters);
                        m = mese.WaitersFullName;
                        return m;

                    }
                    else
                    {
                        return m = "";
                    }
                });
            }
            return mesero;
        }
    }
}