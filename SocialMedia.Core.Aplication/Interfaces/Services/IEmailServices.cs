using SocialMedia.Core.Application.DTOs.Email;
using SocialMedia.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Services
{
  public  interface IEmailServices
    {
        public MailSettings _mailSettings { get; }
        Task SendAsync(EmailRequest request);
    }
}
