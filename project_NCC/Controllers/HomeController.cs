using Microsoft.AspNetCore.Mvc;
using project_NCC.Models;
using System.Diagnostics;

namespace project_NCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Hello Everyone. Welcome To our website.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Saini()
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