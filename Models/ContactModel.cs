using System.ComponentModel.DataAnnotations;

namespace EddiesHikingStore.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(30, ErrorMessage = "First Name cannot exceed 30 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "First Name cannot contain special characters or numbers.")]
        public string? FirstName { get; set; } // Add "?" to mark as nullable

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(30, ErrorMessage = "Last Name cannot exceed 30 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Last Name cannot contain special characters or numbers.")]
        public string? LastName { get; set; } // Add "?" to mark as nullable

        [Required(ErrorMessage = "Address is required.")]
        public string? Address { get; set; } // Add "?" to mark as nullable

        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(10, ErrorMessage = "Phone must be 10 digits.")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Phone must contain numbers only.")]
        public string? Phone { get; set; } // Add "?" to mark as nullable

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; } // Add "?" to mark as nullable

        [Required(ErrorMessage = "Message is required.")]
        public string? Message { get; set; } // Add "?" to mark as nullable
    }
}
