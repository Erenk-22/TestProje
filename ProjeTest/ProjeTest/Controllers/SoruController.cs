using Businesslayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeTest.Controllers
{
    [Authorize]
    public class SoruController : Controller
    {
        UyeSorülarManager uyeSorülar = new UyeSorülarManager(new EFUyeSorülar());
        [HttpGet]
        public IActionResult Soru()
        {
            ViewBag.Sessionn = HttpContext.Session.GetString("UyeId");
            ViewBag.UyeAd = HttpContext.Session.GetString("UyeAdi");
            return View();
        }
        [HttpPost]
        public IActionResult Soru(UyeSorülar p)
        {
            uyeSorülar.AddSoru(p);
            return RedirectToAction("AnaSayfa","Admin");
        }
    }
}
