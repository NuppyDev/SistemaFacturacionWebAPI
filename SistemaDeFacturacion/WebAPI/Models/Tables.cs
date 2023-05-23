using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Tables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableId { get; set; }
        public int EmployeeId { get; set; }
        public Employees Employees { get; set; }
        public IList<Invoice> Invoices { get; set; }
    }
}
