using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _34.Models;

namespace _34.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Connect to the database
            SampleDBContext db = new SampleDBContext();
            // Retrieve departments, and build SelectList
            ViewBag.Departments = new SelectList(db.Departments, "Id", "Name");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}