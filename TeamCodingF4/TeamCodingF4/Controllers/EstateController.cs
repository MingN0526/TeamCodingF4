using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
