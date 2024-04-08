namespace JellweryShopProject.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public SubCategory SubCategoryId { get; set; }
    }
}
