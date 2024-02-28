using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCoursesReservation.Models
{
    public class UserCourse
    {

        public int UserCourseid { get; set; }
        public bool isComplated { get; set; }


        public string UserId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }


        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }

    }
}
