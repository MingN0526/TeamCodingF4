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
using TeamCodingF4.Services;

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
                new Claim("Id",dbAccount.Id.ToString()),
                new Claim(ClaimTypes.Name, dbAccount.Name),
                new Claim(ClaimTypes.Role, dbAccount.IsActive? "會員": ClaimsEnum.訪客.ToString()),
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

        [HttpPost]


        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult ForgetPwd()
        {
            return View();
        }


        [HttpPost]
        public ResponseModel<string> ForgetPwd([FromBody]ForgetPwdRquestModel model)
        {
            ResponseModel<string> _result = new ResponseModel<string>();

            var user = _context.Members.FirstOrDefault(x => x.Email == model.Email);
            if (user == null)
            {
                _result.IsOk = false;
                _result.Message = "找無此使用者，請確認Email。";
                return _result;
            }
            _result.IsOk = true;

            user.IsActive = false;
            user.Token = Guid.NewGuid();

            _context.SaveChanges();

            var activationUrl = "https://localhost:7213/Account/SetNewPwd/" + user.Token;
            var mail = new MailService();

            mail.Send(mail.ToMail(
                "請點選連結進入重置密碼頁面。",
                @$"<h2>請點選下方連結進行新密碼設定。</h2><br>
                <a href='{activationUrl}'>請點我前往修改密碼</a>",
                model.Email
                )
            );

            return _result;
        }

        public IActionResult SetNewPwd(string id)
        {
            ViewBag.id = id;
            return View();
        }



        [HttpPost]
        public ResponseModel<string> SetNewPwd([FromBody]SetNewPwdRequestModel model)
        {
            ResponseModel<string> _result = new ResponseModel<string>();

            var _member = _context.Members.FirstOrDefault(x => x.Token.Equals(Guid.Parse(model.Token)));
            if (_member == null)
            {
                _result.IsOk = false;
                _result.Message = "驗證失敗，請重新操作。";
                return _result;
            }
            _result.IsOk = true;

            string salt = Guid.NewGuid().ToString();
            byte[] addSalt = Encoding.UTF8.GetBytes(model.NewPwd + salt);
            byte[] hashByte = sHA256Managed.ComputeHash(addSalt);
            string hashStr = Convert.ToBase64String(hashByte);

            _member.IsActive = true;
            _member.Password = hashStr;
            _member.PasswordHash = salt;

            _context.SaveChanges();

            return _result;
        }
    }
}
