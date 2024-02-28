using OnlineCoursesReservation.Data;
using OnlineCoursesReservation.Models;

namespace OnlineCoursesReservation_DataAccess.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext context;
        public BaseRepositoy<Course> CourseRepository { get; private set; }

        public BaseRepositoy<Category> CategoryRepository { get; private set; }

        public BaseRepositoy<Teacher> TeacherRepository { get; private set; }

        public BaseRepositoy<Level> LevelRepository { get; private set; }

        public BaseRepositoy<Payment> PaymentRepository { get; private set; }

        public BaseRepositoy<PaymentMethod> PaymentMethodRepository { get; private set; }

        public BaseRepositoy<PaymentStatus> PaymentStatusRepository { get; private set; }

        public BaseRepositoy<Gender> GenderRepository { get; private set; }

        public BaseRepositoy<UserCourse> UserCourseRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            CourseRepository = new BaseRepositoy<Course>(context);
            CategoryRepository = new BaseRepositoy<Category>(context);
            TeacherRepository = new BaseRepositoy<Teacher>(context);
            LevelRepository = new BaseRepositoy<Level>(context);
            PaymentRepository = new BaseRepositoy<Payment>(context);
            PaymentMethodRepository = new BaseRepositoy<PaymentMethod>(context);
            PaymentStatusRepository = new BaseRepositoy<PaymentStatus>(context);
            GenderRepository = new BaseRepositoy<Gender>(context);
            UserCourseRepository = new BaseRepositoy<UserCourse>(context);
        }

        public async Task ComplateAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
