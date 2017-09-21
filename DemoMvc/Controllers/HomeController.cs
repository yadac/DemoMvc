using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    // site/home/index
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        // this method will be called when post back.
        // args is name of posted item.
        [HttpPost]
        public ActionResult About(string userData)
        {
            ViewBag.Message = userData;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // site/home/list
        public ActionResult List()
        {
            return View(TechItem.GetItems());
        }
    }
}