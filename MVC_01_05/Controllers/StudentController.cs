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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString); //Connection
            conn.Open();
            string command = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader r = cmd.ExecuteReader();
            List<CollegeModel> colleges = new List<CollegeModel>();
            while (r.Read())
            {
                CollegeModel college = new CollegeModel();
                college.Id = Convert.ToInt32(r["Id"]);
                college.collegename = Convert.ToString(r["collegename"]);
                college.Address = Convert.ToString(r["Address"]);
                college.Universityname = Convert.ToString(r["Universityname"]);
                colleges.Add(college);
            }
            conn.Close();
            return View(colleges);
        }
        public ActionResult AddToData()
        {
            return View();
        }

        public ActionResult CreateCollege1(CollegeModel college)
        {
            return RedirectToAction("College1");
        }
        [HttpPost]
        public ActionResult AddToDatabase(CollegeModel College)
        {
                //Connection String
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                SqlConnection conn = new SqlConnection(connectionString); //Connection
                conn.Open();//Connection open
                            //string command = "Insert into Student(Id, CollegeName, Address, UniversityName) Values(1,'BMC','Bhaktapur','Tribhuvan University')";
                            //string command = "Insert into Student(Id, CollegeName, Address, UniversityName) Values(2,'Prithvi Narayan Campus','Pokhara','Tribhuvan University'),(3,'NOC','Sanepa','PU')";
            string command = "Insert into Student Values('" + College.Id + "','" + College.collegename + "','" + College.Address + "','" + College.Universityname + "')";
                SqlCommand cmd = new SqlCommand(command, conn); // Sql Command
            cmd.ExecuteNonQuery(); //Execute command
            conn.Close();  

            return RedirectToAction("College1");
        }
        [HttpGet]
        public ActionResult EditCollege(int id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString); //Connection
            conn.Open();
            string command = "SELECT * FROM Student WHERE Id = " + id;
            SqlCommand cmd= new SqlCommand(command, conn); 
            SqlDataReader rd = cmd.ExecuteReader();
            CollegeModel College = new CollegeModel();
            while (rd.Read())
            {
                College.Id = Convert.ToInt32(rd["id"]);
                College.collegename = Convert.ToString(rd["collegename"]);
                College.Address = Convert.ToString(rd["Address"]);
                College.Universityname = Convert.ToString(rd["Universityname"]);
            }
            conn.Close();
            return View(College);

        }
        [HttpPost]
        public IActionResult UpdateCollege(CollegeModel student)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string command = "Update Student set Universityname='" + student.Universityname + "', collegename='" + student.collegename + "', Address ='" + student.Address + "' where Id='" + student.Id + "'";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            return RedirectToAction("College1");
        }
        public IActionResult DeleteCollege(int id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string command = "DELETE FROM Student WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(command,conn);
            cmd.ExecuteNonQuery();  
            conn.Close();

            return RedirectToAction("College1");
        }
        public IActionResult Details(int id) 
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CollegeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string command = "SELECT * FROM Student WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            CollegeModel College = new CollegeModel();

            if (rd.Read())
            {
                College.Id = Convert.ToInt32(rd["Id"]);
                College.collegename = Convert.ToString(rd["collegename"]);
                College.Address = Convert.ToString(rd["Address"]);
                College.Universityname = Convert.ToString(rd["Universityname"]);
            }
            conn.Close();
            return View(College);
        }
    }
}
