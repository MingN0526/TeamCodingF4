using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using TeamCodingF4.Controllers.Services;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers
{
    public class ContactusController : Controller
    {
        private readonly IMailContactUs mailFromContactUs;

        public ContactusController(IMailContactUs mailFromContactUs) 
        {
            this.mailFromContactUs = mailFromContactUs;
        }
        public string SenderMessage([FromBody] EmailFromContactUsModel tempContainer)
        {
            //call ur method
            mailFromContactUs.Send();
            return tempContainer.Email;
        }
    }
}
