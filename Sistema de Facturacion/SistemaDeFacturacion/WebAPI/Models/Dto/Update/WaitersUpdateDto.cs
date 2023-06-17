using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class WaitersUpdateDto
    {
        public int WaitersId { get; set; }
        public string WaitersFullName { get; set; }
    }
}
