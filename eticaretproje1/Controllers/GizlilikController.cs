using eticaretproje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaretproje1.Controllers
{
    [UseAuthorize]
    public class GizlilikController : Controller
    {

        eticaretprojesiEntities db = new eticaretprojesiEntities();
        public ActionResult Index()
        {

            ViewBag.gizlilik = db.Gizlilikİlkesi.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Gizlilikİlkesi data)
        {
            var guncelencekgizlilik = db.Gizlilikİlkesi.Where(x => x.Id == 1).FirstOrDefault();

            guncelencekgizlilik.Anahtar_Kelime = data.Anahtar_Kelime;
            guncelencekgizlilik.Baslik = data.Baslik;
            guncelencekgizlilik.Title = data.Title;
            guncelencekgizlilik.İcerik = data.İcerik;

            int sonuc = db.SaveChanges();
            if (sonuc==1)
            {
                TempData["sonuc"] = 1;
            }
            return RedirectToAction("Index");
        }

    }
}