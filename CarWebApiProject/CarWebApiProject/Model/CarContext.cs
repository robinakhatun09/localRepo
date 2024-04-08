using Microsoft.EntityFrameworkCore;

namespace CarWebApiProject.Model
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions options) : base(options) { }
        public DbSet<Car> Cars { get; set; }


    }
}
