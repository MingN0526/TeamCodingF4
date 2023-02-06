using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Controllers.Services;
using TeamCodingF4.Data;

namespace TeamCodingF4.Controllers.Api
{
    [Route("api/ConfirmEmailApiController/[action]")]
    [ApiController]
    public class ConfirmEmailApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly MailService mailService;

        public ConfirmEmailApiController(ApplicationDbContext context, MailService mailService)
        {
            _context = context;
            this.mailService = mailService;
        }
    }
}
