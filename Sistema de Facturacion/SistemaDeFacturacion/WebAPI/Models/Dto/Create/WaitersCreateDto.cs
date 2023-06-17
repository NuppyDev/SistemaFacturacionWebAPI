using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class WaitersCreateDto
    {
        public int WaitersId { get; set; }
        public string WaitersFullName { get; set; }
    }
}
