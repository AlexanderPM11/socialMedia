
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
 
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }

        //public ICollection<Us> Products { get; set; }
    }
}
