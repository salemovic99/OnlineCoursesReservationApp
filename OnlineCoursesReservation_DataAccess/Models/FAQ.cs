using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation_DataAccess.Models
{
    public class FAQ
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "السوال مطلوب")]
        [StringLength(256)]
        [Display(Name = "السوال")]
        public string Question { get; set; }

        [Required(ErrorMessage = "الجواب مطلوب")]
        [StringLength(512)]
        [Display(Name = "الجواب")]
        public string Answer { get; set; }
    }
}
