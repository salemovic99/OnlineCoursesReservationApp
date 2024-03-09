using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCoursesReservation.Areas.Admin.ViewModels;

namespace OnlineCoursesReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        // GET: RolesController
        public async Task<ActionResult> Index()
        {
            return View(await roleManager.Roles.ToListAsync());
        }



        // POST: RolesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RoleFormViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index", await roleManager.Roles.ToListAsync());
                }

                if (roleManager.RoleExistsAsync(model.Name).Result)
                {
                    ModelState.AddModelError("Name", "الدور موجود!");
                    return View("Index", await roleManager.Roles.ToListAsync());
                }

                await roleManager.CreateAsync(new IdentityRole(model.Name.Trim()));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Problem();
            }
        }

        // GET: RolesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolesController/Edit/5
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



        // POST: RolesController/Delete/5
        [HttpDelete]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }

                var role = await roleManager.FindByIdAsync(id);
                if (role == null)
                {
                    return NotFound();
                }

                await roleManager.DeleteAsync(role);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
