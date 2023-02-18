using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using TeamCodingF4.Data;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.ApiModel;
using TeamCodingF4.Models.Common;
using TeamCodingF4.Services;
using Member = TeamCodingF4.Data.Entity.Member;

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
                    Email = model.Email,
                    Password = hashStr,
                    PasswordHash = salt,
                    Account = model.Email,
                    Token = Guid.NewGuid(),
                    TokenExpireDate = DateTime.Now.AddDays(01),
                };

                _context.Members.Add(_register);
                _context.SaveChanges();

                var activationUrl = "https://localhost:7213/Account/UserValidation/" + _register.Token;
                var mail = mailService.ToMail(
                    "請點選會員認證信中的連結以完成會員認證。",
                    @$"<h2>親愛的會員 {_register.Name} 您好，<br>
                       請點選下方連結以完成會員認證。<br></h2> 
                       <a href='{activationUrl}'>請點我完成會員認證</a>",
                    _register.Email
                    );
                mailService.Send(mail);

                result.IsOk = true;
                return result;
            }
        }

        [HttpPost]
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

                user.Email = model.Email;
                user.Gender = model.Gender;
                user.Identity = model.Identity;
                user.BirthDate = Convert.ToDateTime(model.BirthDate);
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

        public GetProfileModel GetUser()
        {
            var userClaim = User.Claims.FirstOrDefault(x => x.Type == "Id");
            var profile = _context.Members.FirstOrDefault(x => x.Id == int.Parse(userClaim.Value));

            GetProfileModel _user = new GetProfileModel
            {
                Id = profile.Id,
                Name = profile.Name,
                Email = profile.Email,
                Gender = profile.Gender,
                Identity = profile.Identity,
                Job = profile.Job,
                Phone = profile.Phone,
                PicturePath = profile.PicturePath,
            };
            return _user;
        }
    }
}
