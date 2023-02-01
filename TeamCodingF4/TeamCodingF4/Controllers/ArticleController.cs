using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
