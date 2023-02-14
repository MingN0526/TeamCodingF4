using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Controllers.Services
{
	public interface IMailContactUs
	{
		public bool Send(Member member);
	}
}
