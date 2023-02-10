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
            var bloglar = c.Blogs.OrderByDescending(x => x.ID).Take(6).ToList();
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
            var gezi = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(gezi);
        }
        public PartialViewResult PartialSon10Gezi()
        {
            var gezi = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(gezi);
        }
        public PartialViewResult PartialOneCikan()
        {
            var gezi = c.Blogs.Where(x=>x.OneCikan==true).OrderByDescending(x => x.ID).Take(6).ToList();
            return PartialView(gezi);
        }
    }
}