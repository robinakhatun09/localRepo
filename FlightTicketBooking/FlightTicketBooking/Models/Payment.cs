namespace FlightTicketBooking.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public decimal PayPrice { get; set; }
    }
}
