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
using TeamCodingF4.Models.ApiModel;

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

                mailService.Send(_register);

                result.IsOk = true;
                return result;
            }
        }

        public ResponseModel<PostToProfileResponseModel> PostToProfile([FromBody] PostToProfileRequestModel model)
        {
            var result = new ResponseModel<PostToProfileResponseModel>();
            if (!ModelState.IsValid || User.Identity.IsAuthenticated == false)
            {
                result.IsOk = false;
                return result;
            }
            else
            {
                var user = _context.Members.FirstOrDefault(x => x.Name == User.Identity.Name && x.Name == model.Name);

                var profile = new PostToProfileResponseModel
                {
                    //    Id = x.Id,
                    //    Address = x.Address,
                    //    BirthDate = x.BirthDate,
                    //    Email = x.Email,
                    //    Gender = x.Gender,
                    //    Identity = x.Identity,
                    //    Job = x.Job,
                    //    Name = x.Name,
                    //    Phone = x.Phone,
                    //    PicturePath = x.PicturePath,
                };

                result.IsOk = true;
                return result;
            }
        }

        public List<MemberModel> GetProfile()
        {            
            return _context.Members.Select(x => new MemberModel
            {
                Id = x.Id,
                //Address = x.Address,
                BirthDate = x.BirthDate,
                Email = x.Email,
                Gender = x.Gender,
                Identity = x.Identity,
                Job = x.Job,
                Name = x.Name,
                Phone = x.Phone,
                PicturePath = x.PicturePath,
            }).ToList();
        }

    }
}
