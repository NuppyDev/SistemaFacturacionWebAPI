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

        //Es una tarea que devuelve un objeto MesasYMeseros donde guarda la info de id de mesas, meseros y su nombre
        //Esta tarea es la que se usa para frmInitiation y frmCatalogue
        public async Task<MesasYMeseros> ObtenerMesasYMeserosAsync(int id)
        {
            //Se creó una clase MesasYMeseros con tres atributos especificos para que contenga los datos
            //principales para enviarlos a distintos lugares
            MesasYMeseros mm = new MesasYMeseros();
            int numeroMesa = await ObtenerIdMesas(id);
            int idMesero = await ObtenerMeserosConIdMesas(id);
            string nombreMesero = await ObtenerNombreMeseros(idMesero);
            mm.IdMesas = numeroMesa;
            mm.NameMeseros = nombreMesero;
            mm.IdMeseros = idMesero;
            return mm;
        }

        //Es una tarea que devuelve el id de las mesas al obtener un entero en el formulario catalogo
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

        //ObtenerMeserosConIdMesas es una tarea que devuelve un entero que es el id del mesero por medio
        //de la obtencion del id de mesa
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

        //Tarea que devuelve el nombre del mesero, que se busca con el id obtenido de la mesa escogida
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