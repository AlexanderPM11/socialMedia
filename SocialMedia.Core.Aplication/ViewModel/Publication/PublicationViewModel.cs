using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Application.ViewModels.Publication
{
   public class PublicationViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
       
        public string TitlePost { get; set; }
        public int Id_User { get; set; }
        public DateTime Created { get; set; }
    }
}
