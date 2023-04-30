using Microsoft.AspNetCore.Mvc;
using MVC_01_05.Models;
using System.Data.SqlClient;

namespace MVC_01_05.Controllers
{
    public class StudentController : Controller
    {
        Interface _services;
        List<CollegeModel> college = new List<CollegeModel>();
        public StudentController(Interface dateServices)
        {
            _services = dateServices;
        }
        public ActionResult Getdate()
        {
            //Interface dateServices = new NDateservice();
            return Content(_services.Getdate().ToString());
        }
        /*public ActionResult College()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();
            string fileName = "wwwroot/Studentlist.txt";
            StreamReader sr = new StreamReader(fileName);
            string wline = sr.ReadLine();
            while (wline != null)
            {
                string[] collegeDetails = wline.Split(",");
                CollegeModel college = new CollegeModel();
                college.collegename = collegeDetails[0];
                college.Address = collegeDetails[1];
                college.Universityname = collegeDetails[2];
                colleges.Add(college);
                wline = sr.ReadLine();
            }
            sr.Close();
            return View(colleges);
        }
        public ActionResult AddCollege()        {
            return View();
        }
        [HttpPost]
        public ActionResult Createcollege(CollegeModel college)
        {
            string datatoSave = college.collegename + "," + college.Address + "," + college.Universityname;
            StreamWriter sw = new StreamWriter("wwwroot/Studentlist.txt",append: true);
            sw.WriteLine(datatoSave);
            sw.Close();
            return RedirectToAction("College");
        }*/
        public ActionResult College1()
        {
            List<CollegeModel> college = new List<CollegeModel>();
            return View(college);
        }
        public ActionResult AddToData()
        {
            return View();
        }

        public ActionResult CreateCollege1(CollegeModel college)
        {
            return RedirectToAction("College");
        }
        [HttpPost]
        public ActionResult AddToDatabase(CollegeModel College)
        {
                //Connection String
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString); //Connection
                conn.Open();//Connnection open
                //string command = "Insert into Student(Id, CollegeName, Address, UniversityName) Values(1,'BMC','Bhaktapur','Tribhuvan University')";
                string command = "Insert into Student(Id, CollegeName, Address, UniversityName) Values(2,'Prithvi Narayan Campus','Pokhara','Tribhuvan University'),(3,'NOC','Sanepa','PU')";
                SqlCommand cmd = new SqlCommand(command, conn); // Sql Command
                cmd.ExecuteNonQuery(); //Execute command
                return View();
        }

    }
}
