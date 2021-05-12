using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Developerland.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.KategoriSayisi = (from kS in c.Categories select kS).Count();
            ViewBag.PostSayisi = (from bS in c.Posts.Where(x => x.Category.CategoryID == 1) select bS).Count();
            ViewBag.YazarSayisi = (from yS in c.Writers.Where(x => x.WriterFullName.ToLower().Contains("a")) select yS).Count();
            ViewBag.KategoriFiltreli = (from kF in c.Categories orderby kF.Posts.Count() descending select kF.CategoryName).FirstOrDefault();
            ViewBag.TrueFalseFarki =Math.Abs((from trueOlanlar in c.Categories where trueOlanlar.CategoryStatus == true select trueOlanlar).Count()
                - (from falseOlanlar in c.Categories where falseOlanlar.CategoryStatus == false select falseOlanlar).Count())    ;
            return View();
        }
    }
}