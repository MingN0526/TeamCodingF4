using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            TempData["active"] = "detail";
            return View();
        }
    }
}
