using Businesslayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ProjeTest.Controllers
{
    public class AdminController : Controller
    {
        AdminPanelManager uye = new AdminPanelManager(new EFAdminPanel());
        UyeSorülarManager Soru = new UyeSorülarManager(new EFUyeSorülar());
        [HttpGet]
        public IActionResult AdminLogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminLogIn(AdminPanel admin)
        {
            Context c = new Context();
            var bilgiler = c.adminPanels.FirstOrDefault(x => x.AdminMail == admin.AdminMail && x.Password == admin.Password);
            if (bilgiler != null)
            {
                HttpContext.Session.SetString("AdminMail", bilgiler.AdminMail);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.AdminMail)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Istatislik", "Admin");
            }
            else
            {
                ViewBag.Erorr = "Böyle Bir Kullanıcı Bulunmamaktadır.";
                return View();
            }
        }
        public IActionResult Istatislik()
        {
            Context c = new Context();
            ViewBag.Uye = c.kayitSistemis.Count();
            ViewBag.Soru = c.uyeSorülars.Count();
            ViewBag.CV = c.uyeCvs.Count();
            ViewBag.Admin = HttpContext.Session.GetString("AdminMail");
            var values = Soru.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult SıgınUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SıgınUp(AdminPanel model)
        {
            if (model.AdminMail != null && model.Password !=null) {
                uye.AddAdminPanel(model);
                return RedirectToAction("AdminLogIn", "Admin");
            }
            else
            {
                ViewBag.Error = "Mail ve Şifre Boş Geçilemez.";
                return View();
            }
        }
    }
}
