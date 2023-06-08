using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models.Clases
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        [Required]
        public int HistoricalId { get; set; }
        [ForeignKey("HistoricalId")]
        public Historical Historical { get; set; } = null!;
        [Required]
        public int TableId { get; set; }
        [ForeignKey("TableId")]
        public Tables Tables { get; set; } = null!;
        [Required]
        public int WaitersId { get; set; }
        [ForeignKey("WaitersId")]
        public Waiters Waiters { get; set; } = null!;
        [Required]
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
        public List<Description> Descriptions { get; } = new();
        public List<InvoiceDescription> InvoicesDescription { get; } = new();
    }
}
