﻿using System;
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
        BlogYorum blogYorum = new BlogYorum();

        public ActionResult Index()
        {
            blogYorum.Deger1 = context.Blogs.ToList();
            blogYorum.Deger3 = context.Blogs.OrderByDescending(x=>x.Tarih).Take(3).ToList();
            blogYorum.Deger4 = context.Yorumlars.Take(3).ToList();
            //var values = context.Blogs.ToList();
            return View(blogYorum);
        }

        public ActionResult BlogDetay(int id)
        {   
            blogYorum.Deger1 = context.Blogs.Where(x=>x.Id == id).ToList();
            blogYorum.Deger2 = context.Yorumlars.Where(x=>x.BlogId == id).ToList();
            return View(blogYorum);
            //var blogs = context.Blogs.Where(x=>x.Id == id).ToList();
            //return View(blogs);
        }
    }
}