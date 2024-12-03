using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();    
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        public ActionResult BlogDetay(int id)
        {
            var blogs = context.Blogs.Where(x=>x.Id == id).ToList();
            return View(blogs);
        }
    }
}