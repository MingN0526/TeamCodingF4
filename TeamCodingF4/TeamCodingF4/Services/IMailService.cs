using System.Net.Mail;

namespace TeamCodingF4.Services
{
    public interface IMailService
    {
        public void Send(MailMessage mail);

        public MailMessage ToMail(string subject, string body, string to);
    }
}
