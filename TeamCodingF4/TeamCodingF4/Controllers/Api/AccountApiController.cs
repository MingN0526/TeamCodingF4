using Microsoft.AspNetCore.Mvc;
using System.Text;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.Common;
using System.Security.Cryptography;
using TeamCodingF4.Controllers.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/Account/[action]")]
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly MailService mailService;

        public AccountApiController(ApplicationDbContext context, MailService mailService)
        {
            _context = context;
            this.mailService = mailService;
        }
        [HttpPost]
        public ResponseModel<PostToRegisterResponseModel> PostToRegister([FromBody] PostToRegisterRequestModel model)
        {
            var result = new ResponseModel<PostToRegisterResponseModel>();
            if (!ModelState.IsValid || _context.Members.Any(m => m.Email == model.Email))
            {
                result.IsOk = false;
                return result;
            }
            else
            {
                string salt = Guid.NewGuid().ToString();
                byte[] addSalt = Encoding.UTF8.GetBytes(model.Password + salt);
                byte[] hashByte = new SHA256Managed().ComputeHash(addSalt);
                string hashStr = Convert.ToBase64String(hashByte);

                var _register = new Member
                {
                    Name = model.Name,
                    Role = model.Role,
                    Email = model.Email,
                    Password = hashStr,
                    PasswordHash = salt,
                    Account = model.Email,
                    Token = Guid.NewGuid(),
                    TokenExpireDate = DateTime.Now.AddDays(01),
                };

                _context.Members.Add(_register);
                _context.SaveChanges();

                mailService.SendMail(_register);

                result.IsOk = true;
                return result;
            }
        }
    }






}
