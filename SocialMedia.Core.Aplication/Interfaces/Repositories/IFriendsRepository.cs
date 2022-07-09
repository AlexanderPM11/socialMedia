using SocialMedia.Core.Aplication.ViewModel.Friends;
using SocialMedia.Core.Application.Interfaces.Repositories;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Repositories
{
   public interface IFriendsRepository:IGenericRepository<Friends>
    {
        Task<List<Friends>> FilterWithNameFriends(string name);
        Task<Users> GetUserFilterToAdd(string Username);
        Task<Friends> ConfirmUserNoExist(string Username,int Id);
    }
}
