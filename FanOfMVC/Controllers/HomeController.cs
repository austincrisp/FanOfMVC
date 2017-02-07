using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FanOfMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VII()
        {
            return View();
        }

        public ActionResult XIV()
        {
            return View();
        }

        public ActionResult XV()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "So why make a Final Fantasy fansite you might say?  Pretty simple.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Have some ideas of things I can add? Let me know!";

            return View();
        }
    }
}