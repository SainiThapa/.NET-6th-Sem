﻿using Microsoft.AspNetCore.Mvc;
using MVC_01_05.Models;

namespace MVC_01_05.Controllers
{
    public class StudentController : Controller
    {
        List<CollegeModel> college = new List<CollegeModel>();
        public ActionResult Getdate()
        {
            Interface dateServices = new DateServices();
            return Content(dateServices.Getdate().ToString());
        }
        public ActionResult College()
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
        }
    }
}
