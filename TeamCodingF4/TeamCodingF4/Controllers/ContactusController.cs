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
            var msg = $@"聯絡信箱{data.Email}<br>名稱{data.Name}<br>主題{data.Subject}<br>內容{data.Message}";

            var mailMessage = _mailService.ToMail(data.Subject,msg, data.TargetAddress);
            _mailService.Send(mailMessage);

            return data.Email;
        }
    }
}
