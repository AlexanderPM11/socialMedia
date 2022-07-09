
using SocialMedia.Core.Aplication.ViewModel.User;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Domain.Entities;
using System.Threading.Tasks;

namespace SocialMedia.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserViewModel, UserViewModel,Users>
    {
        Task<UserViewModel> Login(Login vm);
        Task<Users> RestorePassword(string emailUsers);
    }
}
