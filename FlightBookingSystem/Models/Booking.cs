namespace FlightBookingSystem.Models
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Guid FlightId { get; set; }
        public Flight? flight { get; set; }
        public Passenger? passenger { get; set; }

    }
}
