using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class BMCcontroller : Controller
    {
        public IActionResult BMC()
        {
            return View();
        }
    }
}
