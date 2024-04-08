using Microsoft.EntityFrameworkCore;

namespace entity.Models
{
   
        public class firstDbContext:DbContext
        {
            public firstDbContext(DbContextOptions options) : base(options) { 
            }
            public DbSet<Employee> Employees { get; set; }

        }
    }

