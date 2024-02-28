using System.ComponentModel.DataAnnotations;

namespace OnlineCoursesReservation.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }

        [MaxLength(256)]
        [Required]
        public string Name { get; set; }

        public ICollection<Payment> Payments { get; set; }//nav prop
    }

}
