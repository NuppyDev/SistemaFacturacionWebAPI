using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models.Clases
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        [Required]
        public int TableId { get; set; }
        public Tables Tables { get; set; } = null!;
        [Required]
        public int WaitersId { get; set; }
        public Waiters Waiters { get; set; } = null!;
        [Required]
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
    }
}
