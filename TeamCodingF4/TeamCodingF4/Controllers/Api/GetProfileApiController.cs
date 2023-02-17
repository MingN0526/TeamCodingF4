using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/GetProfile/[action]")]
    [ApiController]
    [Authorize]
    public class GetProfileApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GetProfileApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        public GetProfileModel GetProfile()
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
                BirthDate = profile.BirthDate.HasValue ? profile.BirthDate.Value.ToString("yyyy/MM/dd") : string.Empty,
                PicturePath = profile.PicturePath,
            };
            return _user;
        }
    }
}
