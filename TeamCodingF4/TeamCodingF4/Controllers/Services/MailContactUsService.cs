using System.Net.Mail;
using System.Net;
using System.Text;
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers.Services
{
    public class MailContactUsService : IMailContactUsService
    {
        public bool Send(ContactusEmailContentModel contactUsTempContainer)
        {
            var mail = new MailMessage();



            mail.Subject = contactUsTempContainer.Subject;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = @$"<h2>名稱: {contactUsTempContainer.Name} <br>
                               Email: {contactUsTempContainer.Email} <br>內容: {contactUsTempContainer.Message} </h2> 
                               ";
            mail.From = new MailAddress("TeamCodingF4@gmail.com", "來自聯絡我們");

            mail.To.Add(new MailAddress("TeamCodingF4@gmail.com"));


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

                mail.Dispose();
                client.Dispose();
            }
        }
    }
    
}
