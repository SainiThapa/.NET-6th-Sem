using Microsoft.AspNetCore.Mvc;
using project_NCC.Models;

namespace project_NCC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StudentView()
        {
            StudentModel Student = new StudentModel();
            Student.FirstName = "Saini";
            Student.LastName = "Thapa";
            Student.Age = 22;
            Student.Address = "Duwakot";
            Student.CollegeName = "BMC";
            return View(Student);
        }

        public ActionResult StudentsView()
        {

            StudentModel saini = new StudentModel();
            saini.FirstName = "Saini";
            saini.LastName = "Thapa Magar";
            saini.Age = 21;
            saini.Address = "Suryabinayak";
            saini.CollegeName = "BMC";

            StudentModel suman = new StudentModel();
            suman.FirstName = "Suman";
            suman.LastName = "Khadka";
            suman.Age = 20;
            suman.Address = "Kadaghari";
            suman.CollegeName = "BMC";
            StudentModel raj = new StudentModel();
            raj.FirstName = "Raj";
            raj.LastName = "Prajapati";
            raj.Age = 24;
            raj.Address = "Sano Thimi";
            raj.CollegeName = "BMC";

            List<StudentModel> Students = new List<StudentModel>();
            Students.Add(suman);
            Students.Add(saini);
            Students.Add(raj);

            return View(Students);
        }
    }
}

