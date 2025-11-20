using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    // Simple User model to store credentials and basic info
    public class User
    {
        public int Id { get; set; } // Primary key/unique identifier

        [Required]
        public string Email { get; set; } // Used as the unique identifier/username

        [Required]
        public string PasswordHash { get; set; } // Hashed password for security

        public string Name { get; set; } // User's full name

        // Default value is "User", can be "Admin", "Manager", etc., for role-based access control
        public string Role { get; set; } = "User";
    }
}