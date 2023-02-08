using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace TravelProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Bloglar { get; set; }
        public IEnumerable<Blog> SonBlog { get; set; }
        public IEnumerable<Yorumlar> Yorumlar { get; set; }
    }
}