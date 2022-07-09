using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Aplication.Interfaces.Repositories;
using SocialMedia.Core.Domain.Entities;
using SocialMedia.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    class FriendsRepository : GenericRepository<Friends>, IFriendsRepository
    {
        private readonly ApplicationContext _dbContext;

        public FriendsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<List< Friends>> FilterWithNameFriends(string name)
        {

            var friends = await _dbContext.Set<Friends>().Where(f => f.UserName == name).ToListAsync();
            return  friends;
        }
        public virtual async Task<Users> GetUserFilterToAdd(string Username)
        {

            var friends = await _dbContext.Set<Users>().FirstOrDefaultAsync(f => f.UserName == Username);
            return friends;
        }
        public virtual async Task<Friends> ConfirmUserNoExist(string Username, int id)
        {
            try
            {
                var friends = await _dbContext.Set<Friends>().SingleAsync(f => f.UserName == Username && f.Id_User==id );
                return friends;
            }
            catch(Exception ex)
            {
                return null;
            }
           
            
        }


    }
}
