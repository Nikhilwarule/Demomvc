using Demomvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Demomvc.Controllers
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
            List<string> colorList = new List<string>()
            {
                "Red","Green","Blue","Yellow","Black","White","Purple","Pink"
            };
           
            ViewData["list"] = colorList;
            ViewBag.ColorList = colorList;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return Aboutus();

        }
        public IActionResult Contactus()
        {
            return Contactus();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
