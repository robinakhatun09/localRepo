using Microsoft.EntityFrameworkCore;

namespace listviewTraveler.Models
{
    public class Travelercontext:DbContext
    {
        public Travelercontext(DbContextOptions options) : base(options) { }
        public DbSet<Traveler> Travelers { get; set; }


    }
}
