using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class CategoriesDto
    {
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
    }
}
