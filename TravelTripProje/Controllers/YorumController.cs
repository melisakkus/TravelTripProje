using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    [Authorize]
    public class YorumController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);
           
        }

        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(yorum);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumGoruntule(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            return View(yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar a)
        {
            var value = context.Yorumlars.Find(a.Id);
            value.Yorum = a.Yorum;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}