using AutoMapper;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.User;
using SocialMedia.Core.Application.DTOs.Email;
using SocialMedia.Core.Application.Interfaces.Repositories;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : GenericService<SaveUserViewModel, UserViewModel, Users>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailServices _emailService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper, IEmailServices emailService) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Login(Login vm)
        {
            Users user = await _userRepository.LoginAsync(vm);

            if (user == null)
            {
                return null;
            }

            UserViewModel userVm = _mapper.Map<UserViewModel>(user);
            return userVm;
        }

        public override async Task<SaveUserViewModel> Add(SaveUserViewModel vm)
        {
            var userRegister = await _userRepository.GetAllAsync();
            var confirmUserNotExis = userRegister.FirstOrDefault(user=>user.UserName==vm.Username);
            var confirmUserEmailNotExis = userRegister.FirstOrDefault(user => user.Email == vm.Email);

            SaveUserViewModel userVm = new();
            if (confirmUserNotExis == null && confirmUserEmailNotExis == null)
            {
                 userVm = await base.Add(vm);
                await _emailService.SendAsync(new EmailRequest
                {
                    To = userVm.Email,
                    From = _emailService._mailSettings.EmailFrom,
                    Body = $"Se ha creado el usuario: {userVm.Username}",
                    Subject = "Creacion de usuario"
                });
                return userVm;
            }
            else if (confirmUserEmailNotExis != null && confirmUserNotExis != null)
            {
                userVm.Email = "Exist";
                userVm.Username = "UserExist";
                return userVm;
            }
            else if (confirmUserEmailNotExis != null)
            {
                userVm.Email = "Exist";
                return userVm;
            }
            else if (confirmUserNotExis != null)
            {
                userVm.Username = "UserExist";
                return userVm;
            }
            return null;


           


        }

        public async Task<List<UserViewModel>> GetAllViewModelWithInclude()
        {
            var userList = await _userRepository.GetAllWithIncludeAsync(new List<string> { "Products" });

            return userList.Select(user => new UserViewModel
            {
                //Name = user.Name,
                //Username = user.Username,
                //Id = user.Id,
                //Email = user.Email,
                //Password = user.Password,
                //Phone = user.Phone
            }).ToList();
        }

        public async Task<Users> RestorePassword(string emailUsers)
        {
          var user= await _userRepository.RestorePassword(emailUsers);

            if (user != null)
            {
                Random rdn = new Random();
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 10;
                string contraseniaAleatoria = string.Empty;
                for (int i = 0; i < longitudContrasenia; i++)
                {
                    letra = caracteres[rdn.Next(longitud)];
                    contraseniaAleatoria += letra.ToString();
                }
                user.Password =  PasswordEcrtyp.ComputeSha256Hash(contraseniaAleatoria); 
               await   _userRepository.UpdateAsync(user, user.Id);

                await _emailService.SendAsync(new EmailRequest
                {
                    To = user.Email,
                    From = _emailService._mailSettings.EmailFrom,
                    Body = $"Saludos querido usuario de nuestra aplicación: <b>{user.Name}</b>. Su nueva contraseña es la siguiente: <b>{contraseniaAleatoria}</b>",
                    Subject = "Creacion de usuario"
                });
                return user;

            }
          return null;
        }
    }
}
