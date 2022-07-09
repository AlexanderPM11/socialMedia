using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.ViewModel.Friends
{
   public class SaveFriendsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public int Id_User { get; set; }
        public string ImageUrl { get; set; }
    }
}
