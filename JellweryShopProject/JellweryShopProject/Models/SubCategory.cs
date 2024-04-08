namespace JellweryShopProject.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
