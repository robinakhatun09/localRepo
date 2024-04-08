using Microsoft.EntityFrameworkCore;

namespace jwellerProject.Models
{
    public class ShopJwelleryContext:DbContext
    {
        public ShopJwelleryContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory>SubCategories { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Bill> Bills { get; set; }

    }
}
