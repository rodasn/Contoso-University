﻿using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //tinfo200:[2021-03-13-rodasn-dykstra1] - set up the default values
       public IActionResult Privacy(string first = "Rodas", string last = "Negussie", 
                                    string email = "rodasn@uw.edu")
        {
            //tinfo200:[2021-03-13-rodasn-dykstra1] - here we are passing variables
            ViewData["FirstName"] = first; 
            ViewData["LastName"] = last;
            ViewData["EmailAddress"] = email;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}