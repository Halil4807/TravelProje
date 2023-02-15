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
        BlogYorum blog = new BlogYorum();
        public ActionResult Index()
        {
            blog.Bloglar = c.Blogs.ToList();
            blog.SonBlog = c.Blogs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            blog.SonYorumlar = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blog);
        }
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            blog.Bloglar = c.Blogs.Where(x => x.ID == id).ToList();
            blog.Yorumlar = c.Yorumlars.Where(x => x.Blogid== id).ToList();
            return View(blog);
        }
        [HttpGet]
        public PartialViewResult PartialYorumYap(int id)
        {
            ViewBag.deger= id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialYorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}