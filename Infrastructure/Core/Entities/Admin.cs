using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Core.Entities
{
    public class Admin : AppUser
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } // الاسم الكامل للإداري

        [Required]
        [MaxLength(50)]
        public string Role { get; set; } // الدور الإداري (مثل "مشرف عام"، "موظف تسجيل"، إلخ)
    }
}
