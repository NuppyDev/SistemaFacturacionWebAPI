using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Dto.Create
{
    public class TablesCreateDto
    {
        public int TableId { get; set; }
        public int WaitersId { get; set; }
    }
}
