using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using TeamCodingF4.Common;
using TeamCodingF4.Data;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.Common;

namespace TeamCodingF4.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SHA256Managed sHA256Managed;

        public AccountController(ApplicationDbContext context, SHA256Managed sHA256Managed)
        {
            _context = context;
            this.sHA256Managed = sHA256Managed;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            TempData["active"] = "member";
            return View();
        }
        public IActionResult Signin()
        {
            TempData["active"] = "member";
            return View();
        }

        //Todo Login RememberMe Function
        [HttpPost]
        public ResponseModel<PostToLoginResponseModel> Signin([FromBody] PostToLoginRequestModel model)
        {
            var result = new ResponseModel<PostToLoginResponseModel>() { IsOk = false,Message="帳號或密碼錯誤" };
            if (!ModelState.IsValid) return result;

            var dbAccount = _context.Members.FirstOrDefault(x => x.Email.Equals(model.Email));           
            if (dbAccount == null) return result;
            byte[] hashByte = sHA256Managed.ComputeHash(Encoding.UTF8.GetBytes(model.Password + dbAccount.PasswordHash));
            string hashStr = Convert.ToBase64String(hashByte);

            if (dbAccount.Password != hashStr) return result;

            var claims = new List<Claim> { 
                new Claim(ClaimTypes.Name, dbAccount.Name),
                new Claim(ClaimTypes.Role, dbAccount.IsActive? dbAccount.Role: ClaimsEnum.訪客.ToString()),
            };
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
            HttpContext.SignInAsync(claimsPrincipal);
            result.IsOk = true;
            return result;
        }
        [HttpGet]
        public IActionResult UserValidation(Guid id)
        {
            var _member = _context.Members.FirstOrDefault(x => x.Token.Equals(id) && x.TokenExpireDate > DateTime.Now && x.IsActive == false);
            if (_member != null)
            {
                _member.IsActive = true;
                _context.SaveChanges();
                return View();
            }
            else
            {
                return View("~/Views/Account/Validationfail.cshtml");
            }
        }

        public IActionResult Validationfail()
        {
            return View();
        }
    }
}
