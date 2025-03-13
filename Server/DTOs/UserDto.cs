using System.ComponentModel.DataAnnotations;

namespace Server.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        [EmailAddress(ErrorMessage = "Pls enter a valid email")]
        public required string Email { get; set; }
        public bool? IsActive { get; set; }
        public string? Role { get; set; }
        public string? RefreshToken { get; set; }
    }
}