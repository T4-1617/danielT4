using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _160927WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from the other side.";
        //}

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}