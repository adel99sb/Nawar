using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Core.Entities
{
    public class Professor : AppUser
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } // الاسم الكامل

        [Required]
        [MaxLength(100)]
        public string Department { get; set; } // القسم

        [Required]
        [Range(0, int.MaxValue)]
        public int MaxProjects { get; set; } // الحد الأقصى للمشاريع التي يمكن الإشراف عليها

        [MaxLength(50)]
        public string? AdminPosition { get; set; } // المنصب الإداري (إن وجد)
    }

}
