using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class TablesDto
    {
        [Required]
        public int TableId { get; set; }
        [Required]
        public int WaitersId { get; set; }
    }
}
