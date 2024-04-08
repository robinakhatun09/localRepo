using Microsoft.EntityFrameworkCore;

namespace JellweryShopProject.Models
{
    public class JewelryShopContext:DbContext
    {
        public JewelryShopContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
