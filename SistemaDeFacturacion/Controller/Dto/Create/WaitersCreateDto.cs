using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class WaitersCreateDto
    {
        [Required]
        public int WaitersId { get; set; }
        [Required]
        public string WaitersFullName { get; set; }
    }
}
