using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void SendMail()
        {
            var mail = new MailMessage();
            mail.Subject = "倪好";
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = @$"<h1>新年快樂</h1> <a href='https://www.google.com'>開啟驗證</a>";
            mail.From = new MailAddress("3591558@gmail.com");

            mail.To.Add(new MailAddress("3591558@gmail.com"));
            mail.To.Add(new MailAddress("a790712a@gmail.com"));
            mail.To.Add(new MailAddress("st5727997@gmail.com"));
            mail.To.Add(new MailAddress("jackymamawang@gmail.com"));
            mail.Attachments.Add(new Attachment($@"{_environment.WebRootPath}\upload\638096522971437290298619.png"));


            var client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("3591558@gmail.com", "mbhbwwmichjoleny");




            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}