using Microsoft.AspNetCore.Mvc;
using Demomvc.Models;
using System.Collections.Generic;


namespace Demomvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            List<Student> student = new List<Student>()
            {
                new Student{RollNo=1,Name= "Rahul",Percentage=75},
                new Student{RollNo=2,Name="Parag",Percentage=65},
                new Student{RollNo=3,Name="Ashwin",Percentage=56},
                new Student{RollNo=4,Name="Manoj",Percentage=89},
                new Student{RollNo=5,Name="Ram",Percentage=72},

            };
            ViewData["studentlist"] = student;

            ViewBag.Products = student;

            return View();
           
        }
    }
}
