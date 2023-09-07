using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace CRUD.Controllers
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
            TempData["name"] = "saini";
            /*HttpContext.Session.SetString("name", "Roshan");
            HttpContext.Session.SetString("Pwd", "123466");*/
            return (RedirectToAction("Get"));
        }
        
        public IActionResult Get()
        {/*
            var name =  HttpContext.Session.GetString("name").ToString();
            var pwd = HttpContext.Session.GetString("Pwd").ToString();
            ViewBag.Name = name;
            ViewBag.Password = pwd;*/
            return View();
        }

        public IActionResult First()
        {
            return View();
        }
        public IActionResult Privacy()
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