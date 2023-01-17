using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
