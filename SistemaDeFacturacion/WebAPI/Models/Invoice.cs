namespace WebAPI.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int TableId { get; set; }
        public int EmployeeId { get; set; }
        public int DescriptionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }

    }
}
