using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mumfordland.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "If you want to know what's up with me, here you go.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "mumfordland is my site, and I'm going to fill it with my stuff.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Track me along with the NSA.";

            return View();
        }
    }
}
