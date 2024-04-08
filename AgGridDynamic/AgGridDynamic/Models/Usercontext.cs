using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AgGridDynamic.Models
{
    public class Usercontext : DbContext
    {
        public Usercontext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }


    }
}
