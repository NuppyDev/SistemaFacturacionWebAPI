using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string EmployeeFullName { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime DateAdmission { get; set; }

        public IList<Tables> Tables { get; set; }
    }
}
