using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Description
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DescriptionId { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = null!;
        public int ProductsId { get; set; }
        public Products Products { get; set; } = null!;
        [Required]
        [Column("Cantidad")]
        public int Cant { get; set; }
        [Required]
        [Column("PrecioUnitario")]
        public decimal UnitePrice { get; set; }
        [Required]
        [Column("Subtotal")]
        public decimal SubTotal { get; set; }
        [Required]
        [Column("Total")]
        public decimal Total { get; set; }
    }
}
