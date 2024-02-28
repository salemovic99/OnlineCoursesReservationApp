using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class PaymentStatus
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Payment> Payments { get; set; }//nav prop
    }
}
