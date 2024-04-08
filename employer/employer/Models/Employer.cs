using System.ComponentModel.DataAnnotations;

namespace employer.Models
{
    public class Employer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^\S+@\S+\.\S+$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a contact number.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Contact number must be 10 digits.")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Please select a course.")]
        [RegularExpression("^(Math|Science|History)$", ErrorMessage = "Invalid course. Choose from Math, Science, or History.")]
        public string Course { get; set; }
        public string City { get; set; }
    }
}
