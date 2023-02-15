using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;

namespace TeamCodingF4.Controllers
{
    public class DetailController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DetailController(ApplicationDbContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index(int id = 1)
        {
            if (id == null || _db.Estates == null)
            {
                return NotFound();
            }
            var product = _db.Estates.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.id = id;
            TempData["active"] = "detail";
            return View();
        }
       
    }
}
