using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Update
{
    public class TablesUpdateDto
    {
        public int TableId { get; set; }
        public int WaitersId { get; set; }
    }
}
