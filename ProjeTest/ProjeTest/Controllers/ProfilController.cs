using Businesslayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeTest.Controllers
{
    [Authorize]
    public class ProfilController : Controller
    {
        KayitSistemiManager kayit = new KayitSistemiManager(new EFKayitSistemi());
        [HttpGet]
        public IActionResult Profil(int id)
        {
            var dep = kayit.GetById(id);
            return View(dep);
        }
        [HttpPost]
        public IActionResult ProfilGuncelle(KayitSistemi model)
        {
            kayit.UpdateKayitIslem(model);
            return RedirectToAction("AnaSayfa","KayitSistemi");
        }
    }
}
