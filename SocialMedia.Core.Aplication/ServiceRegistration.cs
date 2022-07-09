
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.Services;
using SocialMedia.Core.Application.Interfaces.Services;
using System.Reflection;

namespace SocialMedia.Core.Aplication
{

    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IFriendServices, FriendsServices>();
            services.AddTransient<IPublicationServices, PublicationService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICommentServices, CommentServices>();
            #endregion
        }
    }
}
