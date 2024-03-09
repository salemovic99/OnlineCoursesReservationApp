using Microsoft.AspNetCore.Mvc;
using OnlineCoursesReservation_DataAccess.Services.Repositories;

namespace OnlineCoursesReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CoursesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: CoursesController
        public async Task<ActionResult> Index()
        {
            return View(await unitOfWork.CourseRepository.GetAllAsync());
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoursesController/Create
        public async Task<ActionResult> Create()
        {
            //var model = new CourseFormViewModel()
            //{
            //    Categories = unitOfWork.CategoryRepository.GetAllAsync().Result,
            //    Levels = unitOfWork.LevelRepository.GetAllAsync().Result,
            //    Teachers = unitOfWork.TeacherRepository.GetAllAsync().Result
            //};
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
