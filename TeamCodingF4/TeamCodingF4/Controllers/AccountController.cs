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
        public IActionResult Signin()
        {
            return View();
        }

        /*
               [HttpPost]
               [ValidateAntiForgeryToken]
               public IActionResult Register([Bind("UserName, Email, Password, ConfirmePassword")] MemberModel membermodel)
               {
                   if (!ModelState.IsValid)
                   {
                       return View();
                   }
                   var member = _context.Members.Where(m => m.MemberEmail == Members.MemberEmail).FirstOrDefault();
                   if (member == null)
                   {
                           _context.Members.Add(Members);
                           _context.SaveChanges();

                           return RedirectToAction("Login");
                   }
                   Alert("帳號已被使用，請重新註冊");
                   return View();
                   
               }
               */

        /*
 public IActionResult Result()
 {
     var model = TempData["registerModel"] as RegisterModel;
     return View(model);
 }


 [HttpPost]
 [ValidateAntiForgeryToken]
 public async Task<IActionResult> Register([Bind("UserName, Email, Password, ConfirmePassword")] MemberModel memberModel)
 {
     if (!ModelState.IsValid)
     {
     _context.Add(memberModel);
     await _context.SaveChangesAsync();
     return RedirectToAction(nameof(Index));
     }
     else
     {
         TempData["registerModel"] = memberModel;
         return RedirectToAction("Result");
     }
     return View(memberModel);
 }
   */


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
