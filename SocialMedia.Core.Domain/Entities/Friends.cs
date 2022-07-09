using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Domain.Entities
{
   public class Friends: AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public int Id_User { get; set; }
        public int Id_UserRelation { get; set; }
        public string ImageUrl { get; set; }
        public Users User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
