using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers
{
    public class EstateController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public EstateController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            TempData["active"] = "management";
            return View();
        }

        public IActionResult Create()
        {
            TempData["active"] = "management";
            return View();
        }
        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Id=id;
            return View();
        }
    }
}
