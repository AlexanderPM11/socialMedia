using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Comment;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialMedia.Middlewares;

namespace SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPublicationServices _PubliService;
        private readonly IUserService _UserService;
        private readonly ICommentServices _commentServices;
        private readonly ValidateUsers _validateUserSession;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;


        public HomeController(IPublicationServices PubliService, ICommentServices commentServices, IUserService UserService, ValidateUsers validateUserSession, IHttpContextAccessor httpContextAccessor)
        {
            _PubliService = PubliService;
            _commentServices = commentServices;
            _UserService = UserService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
        }

        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            ViewBag.Comment = await _commentServices.GetAllViewModel();
            ViewBag.User = await _UserService.GetAllViewModel();
            return View(await _PubliService.GetAllViewModel());
        }
        public async Task<IActionResult> Comment(IFormCollection form)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (form["comment"].ToString().Trim() == "" || form["Id_Publication"].ToString().Trim() == "")
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



            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
