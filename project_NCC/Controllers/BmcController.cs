using Microsoft.AspNetCore.Mvc;

namespace project_NCC.Controllers
{
    public class BmcController : Controller
    {
        public IActionResult Bmc()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Content()
        {
            return Content("This action returns only this content.");
        }

        public ContentResult Contents()
        {
            return Content("This is a content return test by ContentResult.");
        }
        public JsonResult json()
        {
            return Json(new { name = "Saini", University= "Tribhuvan University" });
        }
        public IActionResult Partial()
        {
            return PartialView("Bmc");  // layout is discarded
        }
        public IActionResult Download()
        {
            return File("~/hello.txt", "text/plain", "myfile.txt");
        }

    }
}
