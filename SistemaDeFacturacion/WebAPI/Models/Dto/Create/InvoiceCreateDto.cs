using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models.Dto.Create
{
    public class InvoiceCreateDto
    {
        public int InvoiceId { get; set; }
        [Required]
        public int HistoricalId { get; set; }
        [Required]
        public int TableId { get; set; }
        [Required]
        public int WaitersId { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
    }
}
