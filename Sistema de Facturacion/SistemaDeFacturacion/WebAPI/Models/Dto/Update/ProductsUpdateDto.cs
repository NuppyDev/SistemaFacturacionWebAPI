using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class ProductsUpdateDto
    {
        public int ProductsId { get; set; }
        public int CategoriesId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
