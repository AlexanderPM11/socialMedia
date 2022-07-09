using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Aplication.ViewModel.User;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialMedia.Middlewares;

using SocialMedia.Core.Aplication.Helpers;

namespace WebApp.SocialMedia.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ValidateUsers _validateUserSession;
        public UserController(IUserService userService, ValidateUsers validateUserSession)
        {
            _userService = userService;
            _validateUserSession = validateUserSession;
        }
        
        public  IActionResult Index()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            var id = ViewBag.chagePassword;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Login vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            UserViewModel userVm = await _userService.Login(vm);
            if (userVm != null)
            {
                HttpContext.Session.Set<UserViewModel>("user",userVm);
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                ModelState.AddModelError("userValidation", "Datos de acceso incorrecto");
            }

            return View(vm);
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }

        public IActionResult Register()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            return View(new SaveUserViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(SaveUserViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            SaveUserViewModel productVm = await _userService.Add(vm);

            if ( productVm.Id != 0)
            {
                productVm.ImageUrl = UploadFile(vm.File, productVm.Id);

                await _userService.Update(productVm, productVm.Id);
            }
            else if (productVm.Username == "UserExist" && productVm.Email == "Exist")
            {
                ModelState.AddModelError("userValidation", "Este email y el nombre de usuario ya esta registrado. Introduzca otro.");
                return View(vm);
            }
            else if (productVm.Username == "UserExist")
            {
                ModelState.AddModelError("userValidation", "Este nombre de usuario ya esta registrado. Introduzca otro.");
                return View(vm);
            }
            else if (productVm.Email == "Exist")
            {
                ModelState.AddModelError("userValidation", "Este email ya esta registrado. Introduzca otro.");
                return View(vm);
            }

            return RedirectToRoute(new { controller = "User", action = "Index" });
        }

        private string UploadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "")
        {
            if (isEditMode)
            {
                if (file == null)
                {
                    return imagePath;
                }
            }
            string basePath = $"/Images/Users/{id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //create folder if not exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //get file extension
            Guid guid = Guid.NewGuid();
            FileInfo fileInfo = new(file.FileName);
            string fileName = guid + fileInfo.Extension;

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            if (isEditMode)
            {
                string[] oldImagePart = imagePath.Split("/");
                string oldImagePath = oldImagePart[^1];
                string completeImageOldPath = Path.Combine(path, oldImagePath);

                if (System.IO.File.Exists(completeImageOldPath))
                {
                    System.IO.File.Delete(completeImageOldPath);
                }
            }
            return $"{basePath}/{fileName}";
        }


    public async Task< IActionResult> RestorePassword( IFormCollection form)
        {
            if (form["emailRestore"].Count != 0)
            {
               var userPasswordChanged= await _userService.RestorePassword(form["emailRestore"]);
                if (userPasswordChanged !=null)
                {
                    ViewBag.chagePassword = "yes";
                return View ("Index" );
                }
                else
                {
                    ViewBag.chagePassword = "no";
                    return View("Index");
                }
                
            }
           return RedirectToRoute(new { controller = "User", action = "Index" });               
            
        }
    }
}
