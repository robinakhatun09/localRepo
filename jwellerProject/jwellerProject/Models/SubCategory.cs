using System.ComponentModel.DataAnnotations.Schema;

namespace jwellerProject.Models
{
    public class SubCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }


        [ForeignKey("Category")]
        public int cid { get; set; }
        public Category Category { get; set; }
    }
}
