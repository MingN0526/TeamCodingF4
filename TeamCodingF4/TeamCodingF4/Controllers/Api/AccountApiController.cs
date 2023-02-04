using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.ApiModel;
using TeamCodingF4.Models.Common;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/Account/[action]")]
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AccountApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ResponseModel<PostToRegisterResponseModel> PostToRegister([FromBody]PostToRegisterRequestModel model)
        {
            var result = new ResponseModel<PostToRegisterResponseModel>(); ;
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
                    Email = model.Email,
                    Password = hashStr,
                    PasswordHash = salt,
                    Account = model.Email,
                };

                _context.Members.Add(_register);
                _context.SaveChanges();

                result.IsOk = true;
                return result;
            }
        }
    }
}
