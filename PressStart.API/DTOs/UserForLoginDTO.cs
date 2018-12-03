using System.ComponentModel.DataAnnotations;

namespace PressStart.API.DTOs
{
    public class UserForLoginDTO
    {
        [Required(ErrorMessage = "Invalid Login")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Invalid Login")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Invalid Login")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Invalid Login")]
        public string Password { get; set; }
    }
}