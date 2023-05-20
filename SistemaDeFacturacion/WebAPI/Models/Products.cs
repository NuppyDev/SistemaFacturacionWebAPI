namespace WebAPI.Models
{
    public class Products
    {
        public int ProductsId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Categories Categories { get; set; }
    }
}
