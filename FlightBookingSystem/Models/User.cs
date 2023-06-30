using System.ComponentModel.DataAnnotations;

namespace FlightBookingSystem.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "This field is Required")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "This field is Required")]
        [DataType(DataType.Text)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = " Email address Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Mobile number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]

        public string Pwd { get; set; } = string.Empty;
       
    }
}
