using Microsoft.AspNetCore.Mvc;

namespace OnlineCoursesReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LevelsController : Controller
    {
        // GET: LevelsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LevelsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LevelsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LevelsController/Create
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

        // GET: LevelsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LevelsController/Edit/5
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

        // GET: LevelsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LevelsController/Delete/5
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
