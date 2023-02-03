using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert()
        {
            return View();
        }
    }
}
