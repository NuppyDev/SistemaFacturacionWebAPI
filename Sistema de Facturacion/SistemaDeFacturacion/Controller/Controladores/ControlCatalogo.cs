using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Dto.Base;

namespace Controler.Controladores
{
    public class ControlCatalogo
    {
        string codigo, nombre, precio;

        //Esta tarea utiliza los datos de un producto para guardarlos en una lista para usarse en vista
        public async Task<List<string>> Productos(int id)
        {
            List<String> productos = new List<String>();
            ProductsDto producto = await ObtenerProducto(id);
            codigo = Convert.ToString(producto.ProductsId);
            nombre = producto.Name;
            precio = Convert.ToString(producto.UnitPrice);
            productos.Add(codigo);
            productos.Add(nombre);
            productos.Add(precio);
            return productos;
        }

        //Esta tarea devuelve los productos con respecto al id deseado en la base de datos
        private async Task<ProductsDto> ObtenerProducto(int id)
        {
            ProductsDto resultado;
            using (var client = new HttpClient())
            {
                resultado = await Task.Run(async () =>
                {
                    ProductsDto t = new ProductsDto();
                    var response = await client.GetAsync(string.Format("{0}/{1}", "https://localhost:7051/api/Products", id));
                    if (response.IsSuccessStatusCode)
                    {
                        var products = await response.Content.ReadAsStringAsync();
                        ProductsDto pro = JsonConvert.DeserializeObject<ProductsDto>(products);
                        t.Name = pro.Name;
                        t.UnitPrice = pro.UnitPrice;
                        t.ProductsId = pro.ProductsId;
                        t.CategoriesId = pro.CategoriesId;
                        return t;
                    }
                    else
                    {
                        MessageBox.Show("La paquetería de datos se ha perdido, los datos de productos no serán entregados a tiempo", "Error en el MeowSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return t;
                    }
                });
            }
            return resultado;
        }
    }
}
