using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class TablesCreateDto
    {
        [Required]
        public int TableId { get; set; }
        [Required]
        public int WaitersId { get; set; }
    }
}
