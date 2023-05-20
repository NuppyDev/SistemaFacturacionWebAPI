namespace WebAPI.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IList<Products> Products { get; set; }
    }
}
