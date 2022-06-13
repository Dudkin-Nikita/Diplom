using CarComponents.Domain;
using CarComponents.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarComponents.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeword("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeword("PageContacts"));
        }
    }
}