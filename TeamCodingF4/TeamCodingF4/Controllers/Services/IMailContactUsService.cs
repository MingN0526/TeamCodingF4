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
using TeamCodingF4.Models;

namespace TeamCodingF4.Controllers.Services
{
    public interface IMailContactUsService
    {
        public bool Send(ContactusEmailContentModel contactUsTempContainer);
    }
}
