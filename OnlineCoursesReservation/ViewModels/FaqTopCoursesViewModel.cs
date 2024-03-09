using OnlineCoursesReservation.Models;
using OnlineCoursesReservation_DataAccess.Models;

namespace OnlineCoursesReservation.ViewModels
{
    public class FaqTopCoursesViewModel
    {
        public IEnumerable<FAQ>? FAQs { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
    }
}
