using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsHasCertificate { get; set; }
        public int Duration { get; set; }
        public float Price { get; set; }
        public float? Discount { get; set; }
        public int EnrollmentCount { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] Thumnail { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int LevelId { get; set; }
        public Level Level { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        public ICollection<UserCourse> UserCourses { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
