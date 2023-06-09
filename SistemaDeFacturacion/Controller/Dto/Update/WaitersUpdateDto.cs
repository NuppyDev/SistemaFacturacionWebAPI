using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class WaitersUpdateDto
    {
        [Required]
        public int WaitersId { get; set; }
        [Required]
        public string WaitersFullName { get; set; }
    }
}
