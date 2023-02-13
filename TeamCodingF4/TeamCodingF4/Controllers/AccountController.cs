using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
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

        public AccountController(ApplicationDbContext context)
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

        //Todo Login RememberMe Function
        [HttpPost]
        public ResponseModel<PostToLoginResponseModel> Signin([FromBody] PostToLoginRequestModel model)
        {
            var dbAccount = _context.Members.FirstOrDefault(x => x.Email.Equals(model.Email));
            var result = new ResponseModel<PostToLoginResponseModel>();
            if (!ModelState.IsValid || dbAccount == null)
            {
                result.IsOk = false;
                return result;
            }
            else
            {
                byte[] addSalt = Encoding.UTF8.GetBytes(model.Password + dbAccount.PasswordHash);
                byte[] hashByte = new SHA256Managed().ComputeHash(addSalt);
                string hashStr = Convert.ToBase64String(hashByte);

                if (dbAccount.Password == hashStr)
                {
                    List<Claim> claims;
                    if (dbAccount.IsActive)
                    {
                        claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Role, dbAccount.Role),
                            new Claim(ClaimTypes.Name, dbAccount.Name),
                        };
                    }
                    else
                    {
                        claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Role, ClaimsEnum.訪客.ToString()),
                            new Claim(ClaimTypes.Name, dbAccount.Name),
                        };
                    }
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    //var b = Enum.Parse<ClaimsEnum>(User.Claims.FirstOrDefault().Value);
                    //var c = b.GetDisplayName();

                    HttpContext.SignInAsync(claimsPrincipal);
                }
                result.IsOk = true;
                return result;
            }
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
