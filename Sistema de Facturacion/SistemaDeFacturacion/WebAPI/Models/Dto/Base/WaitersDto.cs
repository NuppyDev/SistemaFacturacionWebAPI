using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Base
{
    public class WaitersDto
    {
        public int WaitersId { get; set; }
        public string WaitersFullName { get; set; }
    }
}
