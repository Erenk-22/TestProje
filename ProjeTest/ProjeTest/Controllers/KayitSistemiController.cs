using Businesslayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ProjeTest.Controllers
{
   
    public class KayitSistemiController : Controller
    {
        KayitSistemiManager Kayit = new KayitSistemiManager(new EFKayitSistemi());
        [HttpGet]
        public IActionResult KayitIslemi()
        {
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> KayitIslemi(KayitSistemi p)
        {
            Context c = new Context();
            var bilgiler = c.kayitSistemis.FirstOrDefault(x => x.UyeMail == p.UyeMail && x.Sifre == p.Sifre);
           
                if (bilgiler != null)
                {
                    HttpContext.Session.SetString("UyeAdi", bilgiler.UyeMail);
                    HttpContext.Session.SetString("UyeId", Convert.ToString(bilgiler.UyeID));
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UyeMail)
                };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Anasayfa", "KayitSistemi");
                }
                else
                {
                ViewBag.Erorr = "Böyle Bir Kullanıcı Bulunmamaktadır.";
                    return View();
                }
            
          
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(KayitSistemi d)
        {
            //if (!ModelState.IsValid)
            //{
            // Validation kullanıcaktım ama hatalar oluştu zaman kaybetmeden direk kısa yoldan hallettim.
            if (d.UyeAdi != null && d.UyeSoyadi != null && d.UyeMail!=null && d.Sifre!=null)
            {
                Kayit.AddKayitIslem(d);
                return View("KayitIslemi");
            }
            else
            {
                ViewBag.Erorr = "Ad,Soyad,Mail ve Şifre Boş Geçilmemelidir.";
                return View();
            }
            //}
            //else
            //{
            //    return View();
            //}
        }
        [Authorize]
        public IActionResult AnaSayfa()
        {
            
            var values = Kayit.GetList();
            ViewBag.Sessionn= HttpContext.Session.GetString("UyeId");
            ViewBag.Session = HttpContext.Session.GetString("UyeAdi");
            return View(values);
        }
    }
}
