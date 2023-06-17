using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class InvoiceDescriptionUpdateDto
    {
        public int InDeId { get; set; }
        public int InvoiceId { get; set; }
        public int DescriptionId { get; set; }

    }
}
