using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Core.Entities
{
    public class Student : AppUser
    {
        [Required]
        [MaxLength(20)]
        public string UniversityNumber { get; set; }  // رقم الجامعة، ويمكن جعله اسم المستخدم UserName

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } // الاسم الأول

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } // الكنية

        [MaxLength(50)]
        public string FatherName { get; set; } // اسم الأب

        [MaxLength(50)]
        public string MotherName { get; set; } // اسم الأم

        [Required]
        public DateTime BirthDate { get; set; } // تاريخ الميلاد

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow; // تاريخ التسجيل الافتراضي

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; } // الجنس (M أو F)

        [MaxLength(50)]
        public string AdmissionType { get; set; } // نوع القبول (عام، خاص)

        [MaxLength(50)]
        public string Nationality { get; set; } // الجنسية

        [Range(0, 240)]
        public int HighSchoolScore { get; set; } // معدل الثانوية

        [Required]
        public int StudyYear { get; set; } // السنة الدراسية (1-6)

        [Required]
        public int CategoryID { get; set; } // فئة الطالب الأكاديمية

        [MaxLength(20)]
        public string CurrentStatus { get; set; } = "Active"; // الحالة الأكاديمية   
    }
}
