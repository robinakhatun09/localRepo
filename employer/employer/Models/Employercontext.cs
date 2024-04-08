using Microsoft.EntityFrameworkCore;

namespace employer.Models
{
    public class Employercontext : DbContext
    {
        public Employercontext(DbContextOptions options) : base(options) { }
        public DbSet<Employer> Employers { get; set; }

    }
   
}
