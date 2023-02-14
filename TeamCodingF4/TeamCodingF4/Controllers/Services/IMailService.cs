using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Controllers.Services
{
    public interface IMailService
    {
        public bool Send(Member member);
    }
}
