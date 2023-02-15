using AutoMapper.Execution;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using TeamCodingF4.Controllers.Services;
using TeamCodingF4.Models;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Controllers
{
    public class ContactusController : Controller
    {
<<<<<<< HEAD
        //private readonly IMailContactUs mailFromContactUs;

        //public ContactusController(IMailContactUs mailFromContactUs) 
        //{
        //    this.mailFromContactUs = mailFromContactUs;
        //}
        //public string SenderMessage([FromBody] EmailFromContactUsModel tempContainer)
        //{
        //    //call ur method
        //    mailFromContactUs.Send();
=======
        private readonly MailContactUsService mailFromContactUs;

        public ContactusController(MailContactUsService mailFromContactUs) 
        {
            this.mailFromContactUs = mailFromContactUs;
        }
        //public string SenderMessage([FromBody] EmailFromContactUsModel tempContainer)
        //{
        //    //call ur method
        //    var User = new EmailFromContactUsModel
        //    {
        //        Email = tempContainer.Email,
        //        Message = tempContainer.Message,
        //        Name = tempContainer.Name,
        //        Subject = tempContainer.Subject,

        //    };
        //    mailFromContactUs.Send(User);
>>>>>>> 22e1e2058f264bb08fe4d8194a4284e2cfd779f9
        //    return tempContainer.Email;
        //}
    }
}
