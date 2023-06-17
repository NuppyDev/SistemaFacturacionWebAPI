using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class CategoriesCreateDto
    {
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
    }
}
