using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(EstateModel em)
        {
            return Content(em.ToJson());
        }
    }
}
