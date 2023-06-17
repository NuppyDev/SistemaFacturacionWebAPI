using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Clases
{
    public class InvoiceDescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InDeId { get; set; }
        public int InvoiceId { get; set; }
        public int DescriptionId { get; set; }

    }
}
