using SocialMedia.Core.Aplication.ViewModel.Publication;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.Publication;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Services
{
   public interface IPublicationServices : IGenericService<SavePublicaVm, PublicationViewModel, Publication>
    {
        Task<List<PublicationViewModel>> FilterWithFriendId(int id);
         Task<List<PublicationViewModel>> FilterPublica();
    }
}
