using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TeamCodingF4.Models.Account;

namespace TeamCodingF4.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            ViewData["Title"] = "會員註冊";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            var dbAccount = "a790712a@gmail.com";
            var dbPassword = "1314520";

            //資料庫比對
            //_db.user.where(x=> x.account && x.pwd == model.password
            if (model.Email == dbAccount && model.Password == dbPassword)
            {
                var claims = new List<Claim>
                {
                    //principal: cookie裡加密的訊息解密後產生的物件，相當於辦門號時需要的"身分證件"
                    new Claim(ClaimTypes.Name, "Ken"), //資料庫裡的姓名
                    new Claim(ClaimTypes.Role, "Admin"), //資料庫裡的角色
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim("VIP", "1") //可以自訂義XXX(例VIP)，但之後不能打錯
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme); //直接定義他是"身分證明"
                //CookieAuthenticationDefaults.AuthenticationScheme可以是任何詞彙，但後續設定必須一致
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            TempData["error"] = "帳號密碼不正確";
            return RedirectToAction("login");
        }

    }



}
