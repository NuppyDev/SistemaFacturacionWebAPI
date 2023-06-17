using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Controler.Dto
{
    public class WaitersDto
    {
        public int WaitersId { get; set; }
        public string WaitersFullName { get; set; }
    }
}
