using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.TheMessage = "What the hell do you want???";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Got your message.";

            return View();
        }
        [Route("home/create")]
        public ActionResult Create(string message)
        {
            ViewBag.TheMessage = "Inside CREATE.";

            return View("Contact");
        }

        public ActionResult Foo()
        {
            return View("About");
        }
    }
}