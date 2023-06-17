using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controler.Dto
{
    public class InvoiceCreateDto
    {
        public int InvoiceId { get; set; }
        public int TableId { get; set; }
        public int WaitersId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
    }
}
