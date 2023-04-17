using New_webform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_webform.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCollege()
        {
            //List<Collegemodel> college = new List<Collegemodel>();
            return View();
        }

        public ActionResult College()
        {
            List<Collegemodel> college= new List<Collegemodel>();
            return View(college);
        }
        public ActionResult Studentview()
        {
            Studentmodel suman = new Studentmodel();
            suman.First_name = "Saini";
            suman.Last_name = "Thapa";
            suman.Age = 21;
            suman.Address = "Rupandehi";
            suman.CollegeName = "BMC";
            return View(suman);

            Studentmodel Raj= new Studentmodel();
            Raj.First_name = "Raaj";
            Raj.Last_name = "Khan";
            Raj.Age = 23;
            Raj.Address = "Thimi";
            Raj.CollegeName = "Khowpa";
            return View(Raj);

            Studentmodel sagar = new Studentmodel();
            sagar.First_name = "Sagar";
            sagar.Last_name = "Kapoor";
            sagar.Age = 22;
            sagar.Address = "Balaju";
            sagar.CollegeName = "Ambition";
            return View(sagar);

        }
        public ActionResult StudentsView()
        {

            Studentmodel suman = new Studentmodel();
            suman.First_name = "Saini";
            suman.Last_name = "Thapa";
            suman.Age = 21;
            suman.Address = "Rupandehi";
            suman.CollegeName = "BMC";

            Studentmodel Raj = new Studentmodel();
            Raj.First_name = "Raaj";
            Raj.Last_name = "Khan";
            Raj.Age = 23;
            Raj.Address = "Thimi";
            Raj.CollegeName = "Khowpa";

            Studentmodel sagar = new Studentmodel();
            sagar.First_name = "Sagar";
            sagar.Last_name = "Kapoor";
            sagar.Age = 22;
            sagar.Address = "Balaju";
            sagar.CollegeName = "Ambition";

            List<Studentmodel> Students = new List<Studentmodel>();
            Students.Add(suman);
            Students.Add(Raj);
            Students.Add(sagar);

            return View(Students);
        }

    }
}