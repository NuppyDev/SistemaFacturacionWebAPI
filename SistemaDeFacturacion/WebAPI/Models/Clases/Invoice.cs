using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models.Clases
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        public int HistoricalId { get; set; }
        public int TableId { get; set; }
        public Tables Tables { get; set; } = null!;
        public int WaitersId { get; set; }
        public Waiters Waiters { get; set; } = null!;
        public int DescriptionId { get; set; }
        public ICollection<Description> Descriptions { get; } = new List<Description>();
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
    }
}
