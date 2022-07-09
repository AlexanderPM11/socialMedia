using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Repositories;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Publication;
using SocialMedia.Core.Application.ViewModels.Publication;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PublicationService : GenericService<SavePublicaVm, PublicationViewModel, Publication>, IPublicationServices
    {
        private readonly IPublicationRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;

        public PublicationService(IPublicationRepository categoryRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper) :base(categoryRepository, mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }       

        public async Task<List<PublicationViewModel>> GetAllViewModelWithInclude()
        {
            var categoryList = await _categoryRepository.GetAllWithIncludeAsync(new List<string> { "Products"});

            return categoryList.Select(category => new PublicationViewModel
            {
               
            }).ToList();
        }
        
        public override async Task Update(SavePublicaVm vm, int id)
        {
            
            await base.Update(vm, id);
        }
        public async Task<List<PublicationViewModel>> FilterWithFriendId( int id)
        {
            var listPublication =await _categoryRepository.GetAllAsync();

            return listPublication.Where(listPu => listPu.Id_User == id)
                .Select(publication => new PublicationViewModel
            {
                    Id = publication.Id,
                    ImageUrl = publication.ImageUrl,
                    TitlePost = publication.TitlePost,
                    Id_User = publication.Id_User,
                    Created = publication.Created

                }).ToList();
        }
        public async Task<List<PublicationViewModel>> FilterPublica()
        {
            var listPublication = await _categoryRepository.GetAllAsync();
            return listPublication.Where(listPu => listPu.Id_User == userViewModel.Id)
               .Select(publication => new PublicationViewModel
               {
                   Id = publication.Id,
                   ImageUrl = publication.ImageUrl,
                   TitlePost = publication.TitlePost,
                   Id_User=publication.Id_User,
                   Created=publication.Created

               }).ToList();
        }


    }
}
