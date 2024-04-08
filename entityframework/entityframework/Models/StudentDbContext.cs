using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace entityframework.Models

{
    public class StudentDbContext : DbContext { 
    public DbSet<studentlist> studentlists { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=studentlist;Username=postgres;Password=ruby12");
    }

    }
}

