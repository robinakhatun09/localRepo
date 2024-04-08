using Microsoft.EntityFrameworkCore;

namespace demo_page.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions options) : base(options) { }
        public DbSet<Demo> Demos { get; set; }
    }
}
