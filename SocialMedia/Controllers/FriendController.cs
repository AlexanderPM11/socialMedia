using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Aplication.Helpers;
using SocialMedia.Core.Aplication.Interfaces.Services;
using SocialMedia.Core.Aplication.ViewModel.Comment;
using SocialMedia.Core.Aplication.ViewModel.Friends;
using SocialMedia.Core.Application.Interfaces.Services;
using SocialMedia.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialMedia.Middlewares;

namespace WebApp.SocialMedia.Controllers
{
    public class FriendController : Controller
    {
        private readonly IFriendServices _FriendService;
        private readonly IPublicationServices _PubliService;
        private readonly ICommentServices _commentServices;
        private readonly IUserService _UserService;
        private readonly ValidateUsers _validateUserSession;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserViewModel userViewModel;
        public FriendController(IFriendServices FriendService, IPublicationServices PubliService, ICommentServices commentServices, IUserService UserService, ValidateUsers validateUserSession, IHttpContextAccessor httpContextAccessor)
        {
            _FriendService = FriendService;
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

            return View( await _FriendService.FilterFriends());
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }


            return View( await _FriendService.GetByIdSaveViewModel(id));
        }


        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            await _FriendService.Delete(Id);
            return RedirectToRoute(new { controller = "Friend", action = "Index" });
        }



        public async Task<IActionResult> Filtro(IFormCollection formCollection, FriendsViewModel frinds)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (formCollection.Count != 0)
            {
                return View("Index", await _FriendService.FilterWithNameFriends(formCollection["UserFilter"]));
            }
            return View("Index", await _FriendService.GetAllViewModel());
        }

        public async Task<IActionResult> AddFriend(IFormCollection formCollection, FriendsViewModel frinds)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            if (formCollection.Count != 0)
            {
                var con = await _FriendService.AddNewFriend(formCollection["AddFrind"]);
                if (con == null)
                {
                    ViewBag.FindFridn = "UserForAddNoFound";
                    return View("Index", await _FriendService.FilterFriends());
                }
                if (con.Name == "UsernameSame")
                {
                    ViewBag.FindFridn = "UserSame";
                    return View("Index", await _FriendService.FilterFriends());
                }
                
                else if (con.Name=="exist")
                {
                    ViewBag.FindFridn = "userExist";
                    return View("Index", await _FriendService.FilterFriends());
                }

                else
                {
                    ViewBag.FindFridn = "UserFound";
                    return View("Index", await _FriendService.FilterFriends());
                }
            }
            

            return View("Index", await _FriendService.FilterFriends());
        }

        public async Task<IActionResult> PublicationFriend(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            ViewBag.User = await _UserService.GetAllViewModel();
            ViewBag.Comment = await _commentServices.GetAllViewModel();
            return View(await _PubliService.FilterWithFriendId(Id));
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



            return RedirectToRoute(new { controller = "Friend", action = "Index" });
        }

    }
}
