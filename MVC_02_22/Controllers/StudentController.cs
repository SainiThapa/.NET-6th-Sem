using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_02_22.EntityData;

namespace MVC_02_22.Controllers
{
    public class StudentController : Controller
    {
        EntityDB _entityDB;
        public StudentController(EntityDB entityDB) 
        { 
            this._entityDB=entityDB;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentIndex()
        {
            List<Student> students = new List<Student> ();
            students = _entityDB.Students.ToList();
            return View(students);
        }
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student newstudent)
        {
            _entityDB.Students.Add(newstudent);
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
        public IActionResult DeleteStudent(int id)
        {
            var student = _entityDB.Students.Where(x=>x.Id == id).FirstOrDefault();
            _entityDB.Students.Remove(student);
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");
        }

        public IActionResult EditStudent(int id)
        {
            var student = _entityDB.Students.Where(x=>x.Id ==id).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            _entityDB.Attach(student);
            _entityDB.Students.Entry(student).State =  EntityState.Modified;
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
    }
}
