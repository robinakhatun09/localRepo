namespace FlightTicketBooking.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        public string PassengerName { get; set; }
        public int NumberOfSeats { get; set; }
        public string PassengerContact {  get; set; }
        public decimal TotalPrice { get; set; }
    }

}
