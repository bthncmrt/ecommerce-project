using eticaretproje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eticaretproje1.Controllers
{
    [UseAuthorize]
    public class İadeController : Controller
    {
        eticaretprojesiEntities db = new eticaretprojesiEntities();
        public ActionResult Index()
        {

            ViewBag.iade = db.İadeKosullari.ToList();
            return View();
        }

        [HttpPost]

        public ActionResult Index(İadeKosullari data)
        {

            var guncelenecekiade = db.İadeKosullari.Where(x => x.Id == 1).FirstOrDefault();

            guncelenecekiade.Ahatar_kelime = data.Ahatar_kelime;
            guncelenecekiade.Baslik = data.Baslik;
            guncelenecekiade.Title = data.Title;
            guncelenecekiade.İcerik = data.İcerik;
            int sonuc = db.SaveChanges();

            if (sonuc==1)
            {
                TempData["sonuc"] = 1;

            }

            return RedirectToAction("Index");
        }
    }
}