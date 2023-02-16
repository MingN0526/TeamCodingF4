using Microsoft.AspNetCore.Mvc;
using System.Text;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.Common;
using System.Security.Cryptography;
using TeamCodingF4.Models.ApiModel;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
=======
using TeamCodingF4.Services;
>>>>>>> 2c32b404227c72e88e99878eb5d20650358502a6

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/Account/[action]")]
    [ApiController]

    public class AccountApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMailService mailService;
        private readonly SHA256Managed sHA256Managed;

        public AccountApiController(ApplicationDbContext context, IMailService mailService, SHA256Managed sHA256Managed)
        {
            _context = context;
            this.mailService = mailService;
            this.sHA256Managed = sHA256Managed;
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
                byte[] hashByte = sHA256Managed.ComputeHash(addSalt);
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


                var mail = mailService.ToMail("","","");
                mailService.Send(mail);

                result.IsOk = true;
                return result;
            }
        }

        [HttpPost]
        [Authorize]
        public ResponseModel<PostToProfileResponseModel> EditProfile([FromBody] PostToProfileRequestModel model)
        {
            var result = new ResponseModel<PostToProfileResponseModel>();
            if (!ModelState.IsValid || User.Identity.IsAuthenticated == false)
            {
                result.IsOk = false;
                return result;
            }
            else
            {
                var userClaim = User.Claims.FirstOrDefault(x => x.Type == "Id");
                Member user = _context.Members.FirstOrDefault(x => x.Id == int.Parse(userClaim.Value));

                user.BirthDate = model.BirthDate;
                user.Email = model.Email;
                user.Gender = model.Gender;
                user.Identity = model.Identity;
                user.Job = model.Job;
                user.Name = model.Name;
                user.Phone = model.Phone;
                user.PicturePath = model.PicturePath;

                _context.Entry(user).State = EntityState.Modified;

                _context.SaveChanges();
            };
            result.IsOk = true;
            return result;
        }
    }
}
