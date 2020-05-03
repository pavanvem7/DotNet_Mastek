using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6.Models;

namespace _6.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();

            return View(employees);
        }


        public ActionResult Details(int id)
        {
            EmployeeContext emp = new EmployeeContext();
            Employee employee = emp.Employees.Single(empi => empi.Id == id); 
            return View(employee);
        }
    }
}