using SocialMedia.Core.Aplication.ViewModel.Friends;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Services
{
   public interface IFriendServices : IGenericService<SaveFriendsViewModel, FriendsViewModel, Friends>
    {
        Task< List< FriendsViewModel>> FilterWithNameFriends(string name);
        Task<FriendsViewModel> AddNewFriend(string Username);
        Task<List<FriendsViewModel>> FilterFriends();
    }
}
