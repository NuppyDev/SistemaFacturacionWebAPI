using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto
{
    public class WaitersDto
    {
        [Required]
        public int WaitersId { get; set; }
        [Required]
        public string WaitersFullName { get; set; }
    }
}
