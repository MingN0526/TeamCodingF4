using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{

    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            TempData["active"] = "article";
            return View();
        }
        [HttpPost]
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
