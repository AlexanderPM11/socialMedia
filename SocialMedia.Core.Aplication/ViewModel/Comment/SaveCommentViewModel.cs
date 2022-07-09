using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.ViewModel.Comment
{
   public class SaveCommentViewModel
    {
        public int? Id_Friends { get; set; }
        public int? Id_Publication { get; set; }
        public int? Id_User { get; set; }
        public string Commentary { get; set; }
        public string ImageUrl { get; set; }

    }
}
