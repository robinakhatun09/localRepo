using Microsoft.EntityFrameworkCore;

namespace KendoDynamicGrid.Models
{
    public class Studentcontext:DbContext
    {
        public Studentcontext(DbContextOptions options) : base(options) { }
            public DbSet<Student> Students { get; set; }
       
    }
}
