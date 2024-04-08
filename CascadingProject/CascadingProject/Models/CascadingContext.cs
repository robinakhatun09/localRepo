using Microsoft.EntityFrameworkCore;

namespace CascadingProject.Models
{
    public class CascadingContext:DbContext
    {
        public CascadingContext(DbContextOptions options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
