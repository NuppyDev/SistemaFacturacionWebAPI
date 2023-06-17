using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class ProductsDto
    {
        public int ProductsId { get; set; }
        public int CategoriesId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
