﻿using fronti.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test.Models;

namespace fronti.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Reports(List<Employee> list)
        {
            return View(list);
        }

        public IActionResult Administration()
        {
            return View();
        }
    }
}