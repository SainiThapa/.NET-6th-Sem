using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class BmcController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public ContentResult Content()
        {
            return Content("I am a sociopath but in Contentresult");
        }
        public IActionResult json()
        {
            return Json(new { id = 1, name = "suman" });
        }
        public IActionResult Partial()
        {
            return PartialView("Home");
        }
        public IActionResult Saini()
        {
            return PartialView();
        }
        public IActionResult Download() 
        {
            return File("Myfiles/hello.txt","text/plain","file23.dat");
        }
    }
}
