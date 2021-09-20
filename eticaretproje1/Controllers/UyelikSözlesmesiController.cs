using eticaretproje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaretproje1.Controllers
{
    [UseAuthorize]
    public class UyelikSözlesmesiController : Controller
    {

        eticaretprojesiEntities db = new eticaretprojesiEntities();
        public ActionResult Index()
        {

            ViewBag.uyelik = db.Uyesözleşmesi.ToList();
            return View();
        }

        [HttpPost]

        public ActionResult Index(Uyesözleşmesi data)
        {

            var guncelenecekuyelik = db.Uyesözleşmesi.Where(x => x.Id == 1).FirstOrDefault();

            guncelenecekuyelik.Anahtar_Kelime = data.Anahtar_Kelime;
            guncelenecekuyelik.Baslik = data.Baslik;
            guncelenecekuyelik.Title = data.Title;
            guncelenecekuyelik.İcerik = data.İcerik;

            int sonuc = db.SaveChanges();
            if (sonuc==1)
            {
                TempData["sonuc"] = 1;
            }
            return RedirectToAction("Index");
        }

    }
}