using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, MaxLength(256)]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
