using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using System.Security.Principal;
using TeamCodingF4.Data;

namespace TeamCodingF4.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View("~/Views/Account/Signin.cshtml");
            }
        }

        public IActionResult NotLogin()
        {
            return View();
        }
    }
}
