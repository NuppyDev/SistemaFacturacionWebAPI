using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class ProductsDto
    {
        public int ProductsId { get; set; }
        [Required]
        public int CategoriesId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
    }
}
