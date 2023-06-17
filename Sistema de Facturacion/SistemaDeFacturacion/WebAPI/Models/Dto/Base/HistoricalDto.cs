using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class HistoricalDto
    {
        public int HistoricalId { get; set; }
        public int InvoiceId { get; set; }
    }
}
