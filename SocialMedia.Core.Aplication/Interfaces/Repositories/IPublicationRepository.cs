using SocialMedia.Core.Application.Interfaces.Repositories;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.Interfaces.Repositories
{
   public interface IPublicationRepository : IGenericRepository<Publication>
    {
    }
}
