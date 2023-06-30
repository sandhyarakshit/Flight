using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FlightBookingSystem.Models
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }
        public string? FlightId { get; set; }
        [DataType(DataType.Text)]
        public string? Arrival { get; set; } = null;
        [DataType(DataType.Text)]
        public string? Destination { get; set; } = null;
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        
        [DataType(DataType.Time)]
        public TimeSpan ArrivalTime { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Duration { get; set; }
        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "Price is Required")]
        [DataType(DataType.Currency)]
        public long ? Price { get; set; }
        [Display(Name = "Total Seats")]
        public int Capacity { get; set; }
    }
}
