using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAPI.Models.Dto.Update
{
    public class DescriptionUpdateDto
    {
        public int DescriptionId { get; set; }
        [Required]
        public int ProductsId { get; set; }
        [Required]
        public int Cant { get; set; }
        [Required]
        public decimal UnitePrice { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
