namespace OnlineCoursesReservation.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
