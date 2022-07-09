using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Comment;
using SocialMedia.Core.Aplication.ViewModel.Publication;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialMedia.Middlewares;

namespace WebApp.SocialMedia.Controllers
{
    public class PublicationController : Controller
    {
        private readonly IPublicationServices _PubliService;
        private readonly IUserService _UserService;
        private readonly ICommentServices _commentServices;
        private readonly ValidateUsers _validateUserSession;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;
        public PublicationController(IPublicationServices PubliService, IHttpContextAccessor httpContextAccessor, ICommentServices commentServices, IUserService UserService, ValidateUsers validateUserSession)
        {
            _PubliService = PubliService;
            _commentServices = commentServices;
            _UserService = UserService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }
        public async Task< IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            ViewBag.User = await _UserService.GetAllViewModel();
            ViewBag.Comment =await _commentServices.GetAllViewModel();
            return View(await  _PubliService.FilterPublica());
        }

        public IActionResult Create()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            return View( new SavePublicaVm());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePublicaVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if(vm.TitlePost==null && vm.File == null)
            {
                ModelState.AddModelError("userValidation", "Debe haber almenos unos de los campos completos.");
                return View(vm);
            }

            


            vm.Id_user = userViewModel.Id;
            SavePublicaVm productVm = await _PubliService.Add(vm);
            productVm.File = vm.File;

            if (productVm.Id != 0 && productVm.File != null)
            {
                productVm.ImageUrl = UploadFile(vm.File, productVm.Id);

                await _PubliService.Update(productVm, productVm.Id);
            }

            return RedirectToRoute(new { controller = "Publication", action = "Index" });
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            return View("Create", await _PubliService.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SavePublicaVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            if (!ModelState.IsValid)
            {
                return View("Create", vm);
            }
            SavePublicaVm productVm = await _PubliService.GetByIdSaveViewModel(vm.Id);
            vm.ImageUrl = UploadFile(vm.File, vm.Id, true, productVm.ImageUrl);
            vm.Id_user = userViewModel.Id;
            await _PubliService.Update(vm, vm.Id);
            return RedirectToRoute(new { controller = "Publication", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            return View("Delete", await _PubliService.GetByIdSaveViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            await _PubliService.Delete(Id);
            string basePath = $"/Images/Products/{Id}";
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new(path);

                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    folder.Delete(true);
                }

                Directory.Delete(path);
            }

            return RedirectToRoute(new { controller = "Publication", action = "Index" });
        }

        /// <summary>
        /// //
        /// <returns></returns>
        private string UploadFile(IFormFile file, int id, bool isEditMode = false, string imagePath = "")
        {
            if (isEditMode)
            {
                if (file == null)
                {
                    return imagePath;
                }
            }
            string basePath = $"/Images/Products/{id}";
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

        public async Task<IActionResult> Comment(IFormCollection form)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            
                
            if(form["comment"].ToString().Trim()=="" || form["Id_Publication"].ToString().Trim()=="")
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            SaveCommentViewModel comment = new();
             var user = await _UserService.GetByIdSaveViewModel(userViewModel.Id);
             comment.ImageUrl = user.ImageUrl;
             comment.Id_User = userViewModel.Id;
             comment.Commentary = form["comment"];
             comment.Id_Publication = int.Parse(form["Id_Publication"]);
            await _commentServices.Add(comment);           
            

            return RedirectToRoute(new { controller = "Publication", action = "Index" });
        }

    }
}
