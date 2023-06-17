using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAPI.Models.Dto.Update
{
    public class DescriptionUpdateDto
    {
        public int DescriptionId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductsId { get; set; }
        public int Cant { get; set; }
        public decimal UnitePrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
