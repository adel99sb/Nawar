using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Core.DTOs.Requestes
{
    public class VerifyEmailRequestDto
    {
        [Required(ErrorMessage = "User ID is required.")]
        public Guid userId { get; set; }

        [Required(ErrorMessage = "Verification code is required.")]
        [StringLength(6, ErrorMessage = "Verification code must be exactly 6 characters.")]
        public string verificationCode { get; set; }
    }
}
