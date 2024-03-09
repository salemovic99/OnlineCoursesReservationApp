using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCoursesReservation.Models;
using OnlineCoursesReservation.ViewModels;
using OnlineCoursesReservation_DataAccess.Services.Repositories;
using System.Diagnostics;

namespace OnlineCoursesReservation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var faqtopcourses = new FaqTopCoursesViewModel()
            {
                FAQs = await unitOfWork.FaqRepositoy.GetAllAsync()
            };
            return View(faqtopcourses);
        }

        public async Task<IActionResult> Courses()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        [Authorize]
        public IActionResult Payment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}