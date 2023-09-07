using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using System.Data.SqlClient;

namespace WebMVC.Controllers
{
    public class BmcController : Controller
    {
        List<ContactModel> contacts=new List<ContactModel>();
        
        
        
        public IActionResult AddCollege()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Download() 
        {
            return File("Myfiles/hello.txt","text/plain","file23.dat");
        }
    }
}
