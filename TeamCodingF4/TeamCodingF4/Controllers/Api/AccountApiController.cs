using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/account/[action]")]
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AccountApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public List<AccountModel> PostToRegister()
        {
            return _context.Members.Select(x => new AccountModel
            {
                Name = x.Name,
                Email = x.Email,
                Password = x.Password,
            }).ToList();
        }
    }
}
