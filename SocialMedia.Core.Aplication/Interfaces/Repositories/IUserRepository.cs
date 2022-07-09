
using SocialMedia.Core.Aplication.ViewModel.User;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        Task<Users> LoginAsync(Login loginVm);
        Task<Users> RestorePassword(string emailUsers);
    }
}
