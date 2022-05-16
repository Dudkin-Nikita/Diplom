using CarComponents.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarComponents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}