using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class HistoricalCreateDto
    {
        public int HistoricalId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
    }
}
