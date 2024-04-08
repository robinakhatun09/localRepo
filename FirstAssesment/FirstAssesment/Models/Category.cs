using System.Reflection.Metadata;

namespace FirstAssesment.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int price { get; set; }
        public byte[] image { get; set; }
    }
}
