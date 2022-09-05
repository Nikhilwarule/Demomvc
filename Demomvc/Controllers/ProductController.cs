using Microsoft.AspNetCore.Mvc;
using Demomvc.Models;
using System.Collections.Generic;


namespace Demomvc.Controllers
    
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee{Id=1,Name= "Rahul",Salary=34000},
                new Employee{Id=2,Name="Parag",Salary=38000},
                new Employee{Id=3,Name="Ashwin",Salary=39000},
                new Employee{Id=4,Name="Manoj",Salary=3040},
                new Employee{Id=5,Name="Ram",Salary=4000},

            };
            ViewData["employeelist"] = employee;

            ViewBag.Products = employee;

            return View();
        }
    }
}
