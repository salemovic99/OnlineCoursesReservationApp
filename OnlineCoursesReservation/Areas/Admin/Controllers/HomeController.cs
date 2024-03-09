using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCoursesReservation.Models;
using OnlineCoursesReservation_DataAccess.Services.Repositories;

namespace OnlineCoursesReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.UsersCount = userManager.Users.ToListAsync().Result.Count();
            ViewBag.CoursesCount = unitOfWork.CourseRepository.GetAllAsync().Result.Count();
            ViewBag.ReservationCount = unitOfWork.PaymentRepository.GetAllAsync().Result.Count();
            return View();
        }
    }
}
