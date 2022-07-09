using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Domain.Entities
{
   public class Users: AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Tel { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Publication> Publication { get; set; }
        public ICollection<Friends> Friends { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
