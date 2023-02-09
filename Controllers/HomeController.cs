using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Siniflar;

namespace TravelProje.Controllers
{
    public class HomeController : Controller
    {

        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar= c.Blogs.ToList();
            return View(bloglar);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult PartialSon3Gezi()
        {
            return PartialView();
        }
    }
}