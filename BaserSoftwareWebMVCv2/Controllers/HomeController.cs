using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaserSoftwareWebMVCv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult LatestNews()
        {
            return View();
        }
        public ActionResult Policy()
        {
            return View();
        }
        public ActionResult Discord()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
    }
}