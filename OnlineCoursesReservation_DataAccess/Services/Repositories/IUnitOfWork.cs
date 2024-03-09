using OnlineCoursesReservation.Models;
using OnlineCoursesReservation_DataAccess.Models;

namespace OnlineCoursesReservation_DataAccess.Services.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        BaseRepositoy<Course> CourseRepository { get; }
        BaseRepositoy<Category> CategoryRepository { get; }
        BaseRepositoy<Teacher> TeacherRepository { get; }
        BaseRepositoy<Level> LevelRepository { get; }
        BaseRepositoy<Payment> PaymentRepository { get; }
        BaseRepositoy<PaymentMethod> PaymentMethodRepository { get; }
        BaseRepositoy<PaymentStatus> PaymentStatusRepository { get; }
        BaseRepositoy<Gender> GenderRepository { get; }
        BaseRepositoy<UserCourse> UserCourseRepository { get; }
        BaseRepositoy<FAQ> FaqRepositoy { get; }

        Task ComplateAsync();
    }
}
