using System.ComponentModel.DataAnnotations;

namespace Controler.Dto
{
    public class TablesCreateDto
    {
        public int TableId { get; set; }
        public int WaitersId { get; set; }
    }
}
