using Microsoft.AspNetCore.Http;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.SocialMedia.Middlewares
{
    public class ValidateUsers
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ValidateUsers(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            UserViewModel userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");

            if (userViewModel == null)
            {
                return false;
            }
            return true;
        }
    }
}
