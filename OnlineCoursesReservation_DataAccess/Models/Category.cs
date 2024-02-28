using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
