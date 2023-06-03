using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Clases
{
    public class Waiters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WaitersId { get; set; }
        [Required]
        public string WaitersFullName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateAdmission { get; set; }
        public ICollection<Tables> Tables { get; } = new List<Tables>();
        public ICollection<Invoice> Invoices { get; } = new List<Invoice>();
    }
}