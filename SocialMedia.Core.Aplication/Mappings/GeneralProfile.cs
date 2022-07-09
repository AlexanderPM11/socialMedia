using AutoMapper;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Aplication.ViewModel.Publication;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using SocialMedia.Core.Application.ViewModels.Publication;
using SocialMedia.Core.Aplication.ViewModel.Friends;
using SocialMedia.Core.Aplication.ViewModel.Comment;

namespace SocialMedia.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Users, UserViewModel>()
                .ReverseMap()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());
            CreateMap<Users, SaveUserViewModel>()
               .ReverseMap()
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());


            CreateMap<Users, FriendsViewModel>()
                .ForMember(f => f.Id_User, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                 .ForMember(x => x.Password, opt => opt.Ignore())
                  .ForMember(x => x.Email, opt => opt.Ignore())
                    .ForMember(x => x.Tel, opt => opt.Ignore());


            CreateMap<Publication, PublicationViewModel>()
                .ReverseMap()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            CreateMap<Publication, SavePublicaVm>()
                .ForMember(x => x.File, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());
            CreateMap<Friends, SaveFriendsViewModel>()
               
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());
            CreateMap<Friends, FriendsViewModel>()
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            CreateMap<Comment, SaveCommentViewModel>()
              .ReverseMap()
              .ForMember(x => x.Created, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LastModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
              .ForMember(x => x.User, opt => opt.Ignore())
              .ForMember(x => x.Friend, opt => opt.Ignore())
              .ForMember(x => x.Publication, opt => opt.Ignore());
            CreateMap<Comment, CommentViewModel>()
             .ReverseMap()
             .ForMember(x => x.Created, opt => opt.Ignore())
             .ForMember(x => x.CreatedBy, opt => opt.Ignore())
             .ForMember(x => x.LastModified, opt => opt.Ignore())
             .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
             .ForMember(x => x.User, opt => opt.Ignore())
             .ForMember(x => x.Friend, opt => opt.Ignore())
             .ForMember(x => x.Publication, opt => opt.Ignore());
        }
    }
}
