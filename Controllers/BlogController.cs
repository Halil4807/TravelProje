using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Siniflar;

namespace TravelProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var blog = c.Blogs.ToList();
            return View(blog);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.DegerBlog = c.Blogs.Where(x => x.ID == id).ToList();
            by.DegerYorumlar = c.Yorumlars.Where(x => x.Blogid== id).ToList();
            return View(by);
        }
    }
}