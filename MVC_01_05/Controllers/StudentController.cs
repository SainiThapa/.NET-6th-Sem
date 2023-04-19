using Microsoft.AspNetCore.Mvc;
using MVC_01_05.Models;

namespace MVC_01_05.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult College()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();
            StreamReader sr = new StreamReader("wwwroot/college.txt");
            string wline=sr.ReadLine();
            while (wline != null)
            {
                string[] collegeDetails = wline.Split(",");
                CollegeModel college= new CollegeModel();
                college.collegename = collegeDetails[0];
                college.Address = collegeDetails[1];
                college.Universityname = collegeDetails[2];
                colleges.Add(college);
                wline = sr.ReadLine();
            }
            return View(colleges);
        }
        public ActionResult AddCollege()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createcollege(CollegeModel college)
        {
            string datatoSave = college.collegename + "," + college.Address + "," + college.Universityname;
            StreamWriter sw = new StreamWriter("wwwroot/college.txt",true);
            sw.WriteLine(datatoSave);
            sw.Close();
            return RedirectToAction("College");
        }
    }
}
