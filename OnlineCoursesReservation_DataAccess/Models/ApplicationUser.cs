using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public DateTime JoinDate { get; set; }

        public byte[]? ProfilePicture { get; set; }

        public int? GenderId { get; set; }
        public Gender Gender { get; set; }

        public ICollection<UserCourse> UserCourses { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
