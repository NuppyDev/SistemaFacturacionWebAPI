using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class InvoiceDescriptionCreateDto
    {
        public int InDeId { get; set; }
        public int InvoiceId { get; set; }
        public int DescriptionId { get; set; }

    }
}
