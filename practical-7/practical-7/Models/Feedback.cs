using System.ComponentModel.DataAnnotations;

namespace practical_7.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter your feedback")]
        [StringLength(500, MinimumLength = 5,
            ErrorMessage = "Feedback must be 5 to 500 characters")]
        public string Message { get; set; } = "";

        [Required(ErrorMessage = "Please select a rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }
    }
}
