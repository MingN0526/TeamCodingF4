using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
