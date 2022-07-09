using SocialMedia.Core.Aplication.ViewModel.Comment;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Services
{
   public interface ICommentServices: IGenericService<SaveCommentViewModel, CommentViewModel, Comment>
    {
    }
}
