using OnlineCoursesReservation.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Areas.Admin.ViewModels
{
    public class CourseFormViewModel
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "العوان مطلوب")]
        [MaxLength(256)]
        [Display(Name = "العنوان")]
        public string Title { get; set; }


        [Required(ErrorMessage = "الوصف مطلوب")]
        [Display(Name = "الوصف")]

        public string Description { get; set; }

        [Required(ErrorMessage = " مطلوب")]

        [Display(Name = "هل تحتوي على شهادة")]
        public bool IsHasCertificate { get; set; }

        [Required(ErrorMessage = " مطلوب")]

        [Display(Name = "مدة الدورة")]
        public int Duration { get; set; }


        [Required(ErrorMessage = "السعر مطلوب")]
        [Display(Name = "السعر")]
        public float Price { get; set; }


        [Required(ErrorMessage = "الخصم مطلوب")]
        [Display(Name = "الخصم")]
        public float? Discount { get; set; }

        [Required(ErrorMessage = "مطلوب")]

        [Display(Name = "")]
        public int EnrollmentCount { get; set; }


        [Required(ErrorMessage = " مطلوب")]
        [Display(Name = "عدد المقاعد")]
        public int NumberOfSeats { get; set; }

        [Required(ErrorMessage = " مطلوب")]

        [Display(Name = "بدء الدورة")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = " مطلوب")]

        [Display(Name = "نهاية الدورة")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = " صورة مطلوبة")]

        [Display(Name = "صورة الدورة")]
        public byte[] Thumnail { get; set; }


        [Required(ErrorMessage = "  فئة مطلوب")]
        [Display(Name = " فئة الدورة")]
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }

        [Required(ErrorMessage = "  مستوى مطلوب")]

        [Display(Name = " مستوى الدورة")]

        public int LevelId { get; set; }
        public List<Level> Levels { get; set; }

        [Required(ErrorMessage = "  مدرس مطلوب")]

        [Display(Name = " مدرس الدورة")]

        public int TeacherId { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
