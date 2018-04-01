using MvcWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.Country = new List<SelectListItem> { new SelectListItem { Text = "India", Value = "India" },
                new SelectListItem { Text = "Sri Lanka", Value = "Sri Lanka" },
                new SelectListItem { Text = "Singapore", Value = "Singapore" },
                new SelectListItem { Text = "Japan", Value = "Japan" },
                new SelectListItem { Text = "China", Value = "China" },
                new SelectListItem { Text = "Nepal", Value = "Nepal" },
                new SelectListItem { Text = "US", Value = "Us" },
            };
            emp.Name = "Vihaan";
            return View("Employee", emp);
        }

        [HttpPost]
        public ViewResult Save(Employee employee)
        {
            //Saving logic goes here.
            ViewBag.Information = string.Format("Name:{0} and Address:{1} and residing in country: {2}", employee.Name, employee.Address, employee.CountryId);
            return View("Thankyou");
        }
    }
}