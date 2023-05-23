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
        public Invoice Invoice { get; set; }
        public int ProductsId { get; set; }
        public Products Products { get; set; }
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
        [Required]
        [Column("Pagó")]
        public decimal Pay { get; set; }
        [Required]
        [Column("Vuelto")]
        public decimal Change { get; set; }
    }
}
