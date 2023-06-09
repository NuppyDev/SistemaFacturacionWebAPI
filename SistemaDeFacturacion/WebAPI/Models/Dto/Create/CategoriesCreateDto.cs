using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class CategoriesCreateDto
    {
        public int CategoriesId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
