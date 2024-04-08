using Microsoft.EntityFrameworkCore;

namespace FirstAssesment.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory>SubCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart>Carts { get; set; }
        public DbSet<Bill>Bills { get; set; }
        public DbSet<Login>Logins { get; set; }
        public DbSet<Account>Accounts { get; set; }


    }
}
