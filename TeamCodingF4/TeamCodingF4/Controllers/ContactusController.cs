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
        //    return tempContainer.Email;
        //}
    }
}
