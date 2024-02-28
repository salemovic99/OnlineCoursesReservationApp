using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCoursesReservation.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        [Required]
        public byte[] PictureOfBill { get; set; }

        public int CourseId { get; set; }//foreign key

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } //nav prop


        public string UserId { get; set; }//foreign key

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } //nav prop


        public int PaymentStatusId { get; set; }//foreign key

        [ForeignKey(nameof(PaymentStatusId))]
        public PaymentStatus PaymentStatus { get; set; } //nav prop

        public int PaymentMethodId { get; set; }//foreign key

        [ForeignKey(nameof(PaymentMethodId))]
        public PaymentMethod PaymentMethod { get; set; }//nav prop
    }
}
