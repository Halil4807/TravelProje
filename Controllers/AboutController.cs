using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Siniflar;

namespace TravelProje.Controllers
{
    public class AboutController : Controller
    {
        Context contex = new Context();
        // GET: About
        public ActionResult Index()
        {
            var deger = contex.Hakkimizdas.ToList();
            return View(deger);
        }
    }
}