using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Data.Entity;
using TeamCodingF4.Models.Account;
using TeamCodingF4.Models.ApiModel;
using TeamCodingF4.Models.Common;

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
            if (!ModelState.IsValid)
            {
                result.IsOk = false;
                return result;
            }
            else
            {
                var _register = new Member
                {
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password,
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
