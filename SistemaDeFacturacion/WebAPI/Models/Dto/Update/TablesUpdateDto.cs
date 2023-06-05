using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class TablesUpdateDto
    {
        [Required]
        public int TableId { get; set; }
        [Required]
        public int WaitersId { get; set; }
    }
}
