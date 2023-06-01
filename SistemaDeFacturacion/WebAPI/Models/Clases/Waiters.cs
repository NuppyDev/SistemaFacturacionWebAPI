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
        [Column("Nombre Mesero")]
        public string WaitersFullName { get; set; }
        [Required]
        [Column("Cumpleaños")]
        public DateTime Birthday { get; set; }
        [Required]
        [Column("FechaDeIngreso")]
        public DateTime DateAdmission { get; set; }
        public ICollection<Tables> Tables { get; } = new List<Tables>();
        public ICollection<Invoice> Invoices { get; } = new List<Invoice>();
    }
}
}
