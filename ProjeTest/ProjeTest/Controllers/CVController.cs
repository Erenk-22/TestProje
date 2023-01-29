using Businesslayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace ProjeTest.Controllers
{
    [Authorize]
    public class CVController : Controller
    {
        UyeCvManager uye = new UyeCvManager(new EFUyeCv());
        [HttpGet]
        public IActionResult FileUpload()
        {
            ViewBag.Sessionn = HttpContext.Session.GetString("UyeId");
            ViewBag.Session = HttpContext.Session.GetString("UyeAdi");
            return View();
        }
        [HttpPost]
        public IActionResult FileUpload(UyeCv Filee, IFormFile fromFile)
        {
            if (fromFile == null || fromFile.Length == 0)
            {
                ViewBag.Result = "Dosya Yüklenmedi";
                return View();
            }
            var extension = Path.GetExtension(fromFile.FileName).Trim('.').ToLower();
            if (!(new[] { "jpg", "png", "jpeg","pdf","docx" }.Contains(extension)))
            {
                ViewBag.Result = "Uzantı Hatalı";
                return View();
            }
            var local_image_dir = $"D:/Asp.Net/ProjeTest/ProjeTest/Images";
            var local_image_path = $"{local_image_dir}/{fromFile.FileName}";
            if (!Directory.Exists(Path.Combine(local_image_dir)))
                Directory.CreateDirectory(Path.Combine(local_image_dir));
            using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
            {
                fromFile.CopyTo(fileStream);
            }
            Filee.CvDosya = $"{local_image_path}";
            uye.AddUyeCv(Filee);
            ViewBag.Bilgi = "Gönderme işleminiz yapılmıştır.";
            return View();
            

        }
    }
}
                

