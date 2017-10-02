using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           var varible="First commit in git through controller";
            var varb1 = "First Commit in vs ";
            var adjbsd="night";
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
