using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetDate()
        {
            DateService dateService = new DateService();
            return Content(dateService.GetDate().ToString());
        }
    }

}
