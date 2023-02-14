using System.Net.Mail;
using System.Net;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Drawing;
using TeamCodingF4.Data;
using System.Security.Policy;
using System;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Controllers.Services
{
    public class MailService:IMailService
    {

        public bool Send(Member member)
        {
            var mail = new MailMessage();

            var activationUrl = "https://localhost:7213/Account/UserValidation/" + member.Token;

            mail.Subject = "請點選會員認證信中的連結以完成會員認證。";
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = @$"<h2>親愛的會員 {member.Name} 您好，<br>
                               請點選下方連結以完成會員認證。<br></h2> 
                               <a href='{activationUrl}'>請點我完成會員認證</a>";
            mail.From = new MailAddress("TeamCodingF4@gmail.com", "會員認證中心");

            mail.To.Add(new MailAddress("a790712a@gmail.com"));
            //mail.To.Add(new MailAddress(member.Email));

            ////取得檔案
            //Attachment attachment = new Attachment(@"{_environment.WebRootPath}\upload\638096522971437290298619.png");
            ////加入信件
            //mail.Attachments.Add(attachment);

            var client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("TeamCodingF4@gmail.com", "ygaphhgrbffupffg");

            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //attachment.Dispose();
                mail.Dispose();
                client.Dispose();                
            }
        }


    }
}


