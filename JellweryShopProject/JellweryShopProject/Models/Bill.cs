namespace JellweryShopProject.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }  
        public Customer Customer { get; set; }  

      
    }
}
