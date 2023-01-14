using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
