using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models.Dto.Update
{
    public class InvoiceUpdateDto
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
