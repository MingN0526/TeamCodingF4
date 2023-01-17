using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
