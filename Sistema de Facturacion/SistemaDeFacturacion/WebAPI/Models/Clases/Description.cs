using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAPI.Models.Clases
{
    public class Description
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DescriptionId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public int ProductsId { get; set; }
        public Products Products { get; set; } = null!;
        [Required]
        public int Cant { get; set; }
        [Required]
        public decimal UnitePrice { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
