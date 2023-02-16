using System.Net;
using System.Net.Mail;
using System.Text;

namespace TeamCodingF4.Services
{
    public class MailService : IMailService
    {
        public void Send(MailMessage mail)
        {
            var client = new SmtpClient();
            try
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("TeamCodingF4@gmail.com", "ygaphhgrbffupffg");
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mail.Dispose();
                client.Dispose();
            }
        }

        public MailMessage ToMail(string subject, string body, string to)
        {
            var mail = new MailMessage()
            {
                Subject = subject,
                Body = body,
                SubjectEncoding = Encoding.UTF8,
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                From = new MailAddress("TeamCodingF4@gmail.com", "來自聯絡我們"),
            };
            mail.To.Add(new MailAddress(to));
            return mail;

        }
    }
}
