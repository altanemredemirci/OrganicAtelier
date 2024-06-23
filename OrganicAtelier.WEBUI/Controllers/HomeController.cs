using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.Entity;
using OrganicAtelier.WEBUI.EmailServices;

namespace OrganicAtelier.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;

        public HomeController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            return View(id);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult SendEmail(Mail mail)
        {
            string body = $"<h1>Ýletiþim Bilgileri</h1><br>Ad Soyad:{mail.Name}<br>Email:{mail.Email}<br>Konu:{mail.Subject}<br>Mesaj:{mail.Message}";
            bool result = MailHelper.SendMail(body, "ugursevilgen@gmail.com", mail.Subject);
            if (result)
            {
                mail.Read = false;
                _mailService.Create(mail);
                TempData["MailSuccess"] = "true";
            }
            else
            {
                TempData["MailSuccess"] = "false";
            }

            return RedirectToAction("Contact");
        }

    }
}
