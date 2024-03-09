using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Areas.Admin.ViewModels
{
    public class RoleFormViewModel
    {
        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
