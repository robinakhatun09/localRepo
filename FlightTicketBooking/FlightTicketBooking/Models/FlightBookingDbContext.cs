using Microsoft.EntityFrameworkCore;

namespace FlightTicketBooking.Models
{
    public class FlightBookingDbContext:DbContext
    {
        public FlightBookingDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Register>Registers { get; set; }
        public DbSet<Payment>Payments { get; set; }

    }
}
