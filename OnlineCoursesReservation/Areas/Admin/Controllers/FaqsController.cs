using Microsoft.AspNetCore.Mvc;
using OnlineCoursesReservation_DataAccess.Models;
using OnlineCoursesReservation_DataAccess.Services.Repositories;

namespace OnlineCoursesReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public FaqsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<ActionResult> Index()
        {
            return View(await unitOfWork.FaqRepositoy.GetAllAsync());
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(FAQ model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View("Index", await unitOfWork.FaqRepositoy.GetAllAsync());
                }

                await unitOfWork.FaqRepositoy.Add(model);
                await unitOfWork.ComplateAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            return View(await unitOfWork.FaqRepositoy.GetByIdAsync(id));
        }

        // POST: FaqsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(FAQ fAQ)
        {
            try
            {


                if (!ModelState.IsValid)
                {
                    return View(fAQ);
                }

                var result = await unitOfWork.FaqRepositoy.Update(fAQ);
                if (!result)
                {

                    return BadRequest();
                }

                await unitOfWork.ComplateAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Problem();
            }
        }



        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var item = await unitOfWork.FaqRepositoy.GetByIdAsync(id);
                if (item == null)
                    return NotFound();

                var result = await unitOfWork.FaqRepositoy.Delete(item);
                if (!result)
                    return BadRequest();

                await unitOfWork.ComplateAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
