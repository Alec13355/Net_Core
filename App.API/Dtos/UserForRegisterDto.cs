using System.ComponentModel.DataAnnotations;

namespace App.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "You must have a username between 2 to 20 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "You must specify password between 4 to 20 characters")]
        public string Password { get; set; }
    }
}