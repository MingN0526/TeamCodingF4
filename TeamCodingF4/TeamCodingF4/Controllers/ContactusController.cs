using Microsoft.AspNetCore.Mvc;
using TeamCodingF4.Models.ApiModel;
using TeamCodingF4.Services;

namespace TeamCodingF4.Controllers
{
    public class ContactusController : Controller
    {

        private readonly IMailService _mailService;
        
        public ContactusController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public string SenderMessage([FromBody] EmailFromContactUsModel data)
        {
            var msg = $@"dsfsfgfhg{data.Email}{data.Name}";

            var mailMessage = _mailService.ToMail(data.Subject,msg, data.Email);
            _mailService.Send(mailMessage);

            return data.Email;
        }
    }
}
