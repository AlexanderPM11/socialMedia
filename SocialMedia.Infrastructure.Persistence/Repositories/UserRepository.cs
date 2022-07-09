using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.User;
using SocialMedia.Core.Application.DTOs.Email;
using SocialMedia.Core.Application.Interfaces.Repositories;
using SocialMedia.Core.Domain.Entities;
using SocialMedia.Infrastructure.Persistence.Contexts;
using SocialMedia.Infrastructure.Persistence.Repositories;
using System;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private readonly ApplicationContext _dbContext;
        private readonly IEmailServices _emailService;

        public UserRepository(ApplicationContext dbContext, IEmailServices emailService) : base(dbContext)
        {
            _dbContext = dbContext;
            _emailService = emailService;
        }

        public override async Task<Users> AddAsync(Users entity)
        {
            entity.Password = PasswordEcrtyp.ComputeSha256Hash(entity.Password);
            await base.AddAsync(entity);
            return entity;
        }

        public async Task<Users> LoginAsync(Login loginVm)
        {
            string passwordEncrypt = PasswordEcrtyp.ComputeSha256Hash(loginVm.Password);
            Users user = await _dbContext.Set<Users>().FirstOrDefaultAsync(user => user.UserName == loginVm.Username && user.Password == passwordEncrypt);
            return user;
        }
        public async Task<Users> RestorePassword(string emailUsers)
        {
            Users users = await _dbContext.Set<Users>().FirstOrDefaultAsync(user => user.Email == emailUsers);
            
           return users;
        }
            
        

    }
}
