using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class InvoiceDescriptionDto
    {
        public int InDeId { get; set; }
        public int InvoiceId { get; set; }
        public int DescriptionId { get; set; }

    }
}
