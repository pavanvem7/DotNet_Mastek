using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id, string name)
        {
            return "id=" + id + "Name = " + Request.QueryString["name"];
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public string GetDetails()
        {
            return ("Get Details");
        }
        
    }
}