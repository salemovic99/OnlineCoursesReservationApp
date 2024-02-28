using Microsoft.AspNetCore.Mvc;

namespace OnlineCoursesReservation.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult FilterCourses(int priceRange, string certificate)
        //{
        //    var filteredCourses = _context.Courses.AsQueryable();

        //    // Parse price range
        //    if (!string.IsNullOrEmpty(priceRange))
        //    {
        //        var priceLimits = priceRange.Split('-').Select(decimal.Parse).ToList();
        //        var minPrice = priceLimits[0];
        //        var maxPrice = priceLimits[1];
        //        filteredCourses = filteredCourses.Where(c => c.Price >= minPrice && c.Price <= maxPrice);
        //    }

        //    // Parse certificate
        //    if (!string.IsNullOrEmpty(certificate))
        //    {
        //        var hasCertificate = bool.Parse(certificate);
        //        filteredCourses = filteredCourses.Where(c => c.HasCertificate == hasCertificate);
        //    }

        //    var filteredCourseList = filteredCourses.ToList();

        //    return PartialView("_CourseListPartial", filteredCourseList);
        //}

    }
}
