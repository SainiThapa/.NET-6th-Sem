﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_02_22.Models;
using System.Diagnostics;

namespace MVC_02_22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize (Roles ="Admin,Staff")]
        public IActionResult    Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddSession()
        {
            HttpContext.Session.SetString("Username", "Saini");
            Response.Cookies.Append("StudentId", "23264");
            return View();
        }

        public IActionResult ReadSession()
        {
            string username = HttpContext.Session.GetString("Username");
            ViewBag.Username = username;
            ViewData["college"] = "Horizon GBS";
            TempData["address"] = "Tilotama";
            string StudentId= HttpContext.Request.Cookies["StudentId"].ToString();
            ViewBag.StudentId = StudentId;
            return View();
        }
        public IActionResult RemoveCookie()
        {
            return View();
        }

    }
}