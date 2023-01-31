using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TeamCodingF4.Models.Account;
using AutoMapper.Execution;
using TeamCodingF4.Data;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind("UserName, Email, Password, ConfirmePassword")] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                return View(registerModel);
            }
            else
            {
                TempData["registerModel"] = registerModel;
                return RedirectToAction("Result");
            }
        }

        public ActionResult Result()
        {
            var model = TempData["registerModel"] as RegisterModel;
            return View(model);
        }
        */

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("UserName, Email, Password, ConfirmePassword")] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["registerModel"] = registerModel;
                return RedirectToAction("Result");
            }
            return View(registerModel);
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {

            var dbAccount = "a790712a@gmail.com";
            var dbPassword = "1111";

            //資料庫比對
            //_db.user.where(x=> x.account && x.pwd == model.password
            if (loginModel.Email == dbAccount && loginModel.Password == dbPassword)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Ken"), 
                    new Claim(ClaimTypes.Role, "Admin"), 
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim("VIP", "1") 
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            TempData["error"] = "帳號密碼不正確";
            return RedirectToAction("login");
        }

    }



}
