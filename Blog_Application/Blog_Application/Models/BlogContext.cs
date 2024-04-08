using Microsoft.EntityFrameworkCore;

namespace Blog_Application.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) : base(options) { }
        public DbSet<BlogPosts> BlogPost { get; set; }

    }
}
