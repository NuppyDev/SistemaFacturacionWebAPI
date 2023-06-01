using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Clases
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriesId { get; set; }
        [Required]
        [Column("Categoría")]
        public string CategoryName { get; set; }
        public ICollection<Products> Products { get; } = new List<Products>();
    }
}
