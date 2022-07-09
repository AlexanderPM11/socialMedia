using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Domain.Entities
{
  public  class Comment:AuditableBaseEntity
    {
        public int? Id_Friends { get; set; }
        public int? Id_Publication { get; set; }
        public int? Id_User{ get; set; }
        public string Commentary { get; set; }
        public string ImageUrl { get; set; }
        public Users User { get; set; }
        public Publication Publication { get; set; }
        public Friends Friend { get; set; }
    }
}
