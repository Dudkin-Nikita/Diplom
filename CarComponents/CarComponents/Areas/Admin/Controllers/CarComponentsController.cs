using CarAccessories.Service;
using CarComponents.Domain;
using CarComponents.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarComponents.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarComponentsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public CarComponentsController(DataManager dataManger, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManger;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new CarComponent() : dataManager.CarComponents.GetCarComponentById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(CarComponent entity, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    entity.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.CarComponents.SaveCarComponent(entity);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.CarComponents.DeleteCarComponent(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
