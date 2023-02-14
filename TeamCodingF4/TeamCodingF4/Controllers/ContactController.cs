using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            TempData["active"] = "contact";
            return View();
        }
    }
}
