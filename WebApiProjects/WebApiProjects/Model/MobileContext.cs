using Microsoft.EntityFrameworkCore;

namespace WebApiProjects.Model
{
    public class MobileContext:DbContext
    {
        public MobileContext(DbContextOptions options) : base(options) { }
        public DbSet<Mobile> Mobiles { get; set; }

    }
}
