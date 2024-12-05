using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var bloglar = context.Blogs.ToList();
            return View(bloglar);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var blog = context.Blogs.Find(id);
            return View(blog);
        }

        [HttpPost]
        public ActionResult BlogGuncelle(Blog model)
        {
            var blog = context.Blogs.Find(model.Id);
            blog.Baslik = model.Baslik;
            blog.Aciklama = model.Aciklama;
            blog.Tarih = model.Tarih;
            blog.BlogImage = model.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}