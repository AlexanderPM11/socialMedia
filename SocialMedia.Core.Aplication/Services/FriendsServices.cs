using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Repositories;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Friends;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Services
{
   public class FriendsServices: GenericService<SaveFriendsViewModel, FriendsViewModel, Friends>, IFriendServices
    {
        private readonly IFriendsRepository _friendRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;

        public FriendsServices(IFriendsRepository friendRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(friendRepository, mapper)
        {
            _friendRepository = friendRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public async Task<List<FriendsViewModel>> GetAllViewModelWithInclude()
        {
            var categoryList = await _friendRepository.GetAllWithIncludeAsync(new List<string> { "Products" });

            return categoryList.Select(category => new FriendsViewModel
            {

            }).ToList();
        }
        public override async Task<SaveFriendsViewModel> Add(SaveFriendsViewModel vm)
        {
            vm.Id_User= 4;
            return await base.Add(vm);
        }
        public override async Task Update(SaveFriendsViewModel vm, int id)
        {
            vm.Id_User = 4;
            await base.Update(vm, id);
        }
        public  async Task< List< FriendsViewModel>> FilterWithNameFriends(string name)
        {
            var friends = await _friendRepository.FilterWithNameFriends(name);

            return _mapper.Map<List<FriendsViewModel>>(friends);
        }

        public async Task<FriendsViewModel> AddNewFriend(string Username)
        {
            
            FriendsViewModel friends=new();
            var friendAdd = await _friendRepository.ConfirmUserNoExist(Username, userViewModel.Id);
            if (Username == userViewModel.Username)
            {
                friends.Name = "UsernameSame";
                return friends;
            }

           
            else if (friendAdd == null)
            {
                var user = await _friendRepository.GetUserFilterToAdd(Username);

                if (user != null)
                {
                     friends = _mapper.Map<FriendsViewModel>(user);
                    friends.Id_User = userViewModel.Id;
                    friends.Id_UserRelation = user.Id;
                    Friends friendsAdd = _mapper.Map<Friends>(friends);
                    friendsAdd.Id = 0;
                    await _friendRepository.AddAsync(friendsAdd);
                    return friends;
                }
                else
                {
                    return null;
                }
            }
            
            friends.Name = "exist";
            return friends;
        }

        public async Task<List<FriendsViewModel>> FilterFriends()
        {
            var listPublication = await _friendRepository.GetAllAsync();
            return listPublication.Where(listPu => listPu.Id_User == userViewModel.Id)
               .Select(publication => new FriendsViewModel
               {
                   Id = publication.Id,
                   ImageUrl = publication.ImageUrl,
                   Name = publication.Name,
                   Lastname=publication.Lastname,
                   UserName=publication.UserName,
                   Id_User=publication.Id_User,
                   Id_UserRelation=publication.Id_UserRelation


               }).ToList();
        }
    }
}
