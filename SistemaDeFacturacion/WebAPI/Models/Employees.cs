using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Required]
        [Column("NombreEmpleado")]
        public string EmployeeFullName { get; set; }
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
