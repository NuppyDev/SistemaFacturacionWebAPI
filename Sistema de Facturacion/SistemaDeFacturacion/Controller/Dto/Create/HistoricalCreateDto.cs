using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class HistoricalCreateDto
    {
        public int HistoricalId { get; set; }
        public int InvoiceId { get; set; }
    }
}
