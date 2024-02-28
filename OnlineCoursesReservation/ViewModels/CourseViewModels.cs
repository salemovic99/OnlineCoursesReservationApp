using OnlineCoursesReservation.Models;

namespace OnlineCoursesReservation.ViewModels
{
    public class CourseViewModels
    {
        public IEnumerable<Course> Courses { get; set; }
        public double Price { get; set; }
        public bool HasCertificate { get; set; }
    }
}
