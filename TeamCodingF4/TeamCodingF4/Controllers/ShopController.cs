using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index(int xxx,string xxxaaa)
        {
            TempData["active"] = "shop";
            return View();
        }
    }
}
