using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class WaitersCreateDto
    {
        public int WaitersId { get; set; }
        public string WaitersFullName { get; set; }
    }
}
