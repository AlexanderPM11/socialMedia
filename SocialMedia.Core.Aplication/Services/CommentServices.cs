using Application.Services;
using AutoMapper;
using SocialMedia.Core.Aplication.Interfaces.Repositories;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Comment;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Services
{
  public  class CommentServices:GenericService<SaveCommentViewModel, CommentViewModel, Comment>, ICommentServices
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentServices(ICommentRepository commentRepository, IMapper mapper) : base(commentRepository, mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
            //userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }
    }
}
