using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class YeniYorumEkleController : Controller
    {
        // GET: YeniYorumEkle
        Context context = new Context();

        [HttpGet]
        public PartialViewResult Index(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public ActionResult Index(Yorumlar y)
        {
            context.Yorumlars.Add(y);
            context.SaveChanges();
            return RedirectToAction("BlogDetay","Blog");
        }
    }
}