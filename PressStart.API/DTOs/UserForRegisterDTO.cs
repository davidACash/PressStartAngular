using System.ComponentModel.DataAnnotations;

namespace PressStart.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Username must be between 8 and 16 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 32 characters.")]
        public string Password { get; set; }
    }
}