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
	public class IMailContactUsService : IMailContactUs
	{

		public bool Send(Member member)
		{
			var mail = new MailMessage();

			

			mail.Subject = "{ContactUs-Subject}";
			mail.SubjectEncoding = Encoding.UTF8;
			mail.IsBodyHtml = true;
			mail.BodyEncoding = Encoding.UTF8;
<<<<<<< HEAD
			//mail.Body = @$"<h2>名稱: {member.Name} <br>
   //                            Email: {} <br>內容: {} </h2> 
   //                            ";
			mail.From = new MailAddress("TeamCodingF4@gmail.com", "會員認證中心");
=======
			mail.Body = @$"<h2>名稱: {member.Name} <br>
                               Email: {member.Name} <br>內容: {member.Name} </h2> 
                               ";
			mail.From = new MailAddress("TeamCodingF4@gmail.com", "來自聯絡我們");
>>>>>>> a2557c02216421889a8e3dad4d97cb2b821a4c66

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
