using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Domain.Entities
{
   public class Publication: AuditableBaseEntity
    {
        public string ImageUrl { get; set; }
        public string TitlePost { get; set; }
        public int Id_User { get; set; }
        public Users User { get; set; }
        public ICollection<Comment> Comments { get; set; }



    }
}
