namespace WebAPI.Models
{
    public class Description
    {
        public int DescriptionId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductsId { get; set; }
        public int Cant { get; set; }
        public decimal UnitePrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Pay { get; set; }
        public decimal Change { get; set; }

    }
}
