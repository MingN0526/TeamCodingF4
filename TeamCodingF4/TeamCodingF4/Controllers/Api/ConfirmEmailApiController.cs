using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Data;
using TeamCodingF4.Services;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/ConfirmEmailApiController/[action]")]
    [ApiController]
    public class ConfirmEmailApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMailService mailService;

        public ConfirmEmailApiController(ApplicationDbContext context, IMailService mailService)
        {
            _context = context;
            this.mailService = mailService;
        }
    }
}
