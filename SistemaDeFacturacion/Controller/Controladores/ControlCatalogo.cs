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
                        return t;
                    }
                });
            }
            return resultado;
        }
    }
}
