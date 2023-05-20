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
        public int ProductsId { get; set; }
        public int Cant { get; set; }
        public decimal UnitePrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Pay { get; set; }
        public decimal Change { get; set; }
        public IList<Products> Products { get; set; }
    }
}
