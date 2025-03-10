using System.ComponentModel.DataAnnotations;

namespace Nawar.API.Core.DTOs.Requestes
{
    public class ResetPasswordRequestDto
    {
        [Required(ErrorMessage = "User ID is required.")]
        public Guid userId { get; set; }

        [Required(ErrorMessage = "Reset token is required.")]
        public string resetToken { get; set; }

        [Required(ErrorMessage = "New password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "New password must be at least 6 characters long.")]
        public string newPassword { get; set; }
    }
}
