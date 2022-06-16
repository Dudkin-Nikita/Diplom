using CarComponents.Domain;
using CarComponents.Domain.Entities;
using CarComponents.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarComponents.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly DataManager dataManager;
        public ComponentsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.CarComponents.GetCarComponentById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageComponents");
            return View(dataManager.CarComponents.GetCarComponents());
        }

        public IActionResult Selection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SelectionList(CarComponentModel entity)
        {
            if (entity.Type != null)
            {
                IQueryable<CarComponent> carComponents = dataManager.CarComponents.GetCarComponents();
                carComponents = carComponents.Where(p => p.Type == entity.Type);
                if (entity.Name != null)
                {
                    carComponents = carComponents.Where(p => p.Name == entity.Name);
                }
                if (entity.Mark != null)
                {
                    carComponents = carComponents.Where(p => p.Mark == entity.Mark);
                }
                if (entity.Model != null)
                {
                    carComponents = carComponents.Where(p => p.Model == entity.Model);
                }
                if (entity.MaxPrice != 0)
                {
                    carComponents = carComponents.Where(p => p.Price <= entity.MaxPrice);
                }
                if (entity.MinPrice != 0)
                {
                    carComponents = carComponents.Where(p => p.Price >= entity.MinPrice);
                }
                return View(carComponents);
            }
            return RedirectToAction("Selection", "Components");
        }
        public IActionResult Filter()
        {
            IQueryable<CarComponent> carComponents = dataManager.CarComponents.GetCarComponents();
            return View(carComponents);
        }

        [HttpPost]
        public IActionResult FilterList(string type, string component)
        {
            IQueryable<CarComponent> carComponents = dataManager.CarComponents.GetCarComponents();
            if (type == "Type")
            {
                carComponents = carComponents.Where(c => c.Type.Contains(component));
            }
            if (type == "Type")
            {
                carComponents = carComponents.Where(c => c.Type == component);
            }
            if (type == "Mark")
            {
                carComponents = carComponents.Where(c => c.Mark == component);
            }
            if (type == "Model")
            {
                carComponents = carComponents.Where(c => c.Model == component);
            }
            return View(carComponents);
        }
    }
}
