using Microsoft.AspNetCore.Mvc;

namespace TeamCodingF4.Controllers
{
    public class ArticleReplyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReplyContent()
        {
            return View();
        }
    }
}
