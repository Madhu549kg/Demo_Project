using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your apxplicatvccion description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact    vpvage .";

            return View();
        }
    }
}