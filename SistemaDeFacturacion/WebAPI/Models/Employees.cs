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

        public IList<Tables> Tables { get; set; }
        public IList<Invoice> Invoices { get; set; }
    }
}
