using Microsoft.EntityFrameworkCore;
using System;

namespace listviewkendoui.Models
{
    public class Productcontext:DbContext
    {
        public Productcontext(DbContextOptions<Productcontext> options) : base(options) { }

        public DbSet<BeautyProduct> BeautyProducts { get; set; }
    }
}
