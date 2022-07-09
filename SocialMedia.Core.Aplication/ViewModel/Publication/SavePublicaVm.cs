using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.ViewModel.Publication
{
   public class SavePublicaVm
    {
        public int Id { get; set; }
        public int Id_user { get; set; }
        public string ImageUrl { get; set; }
        public string TitlePost { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
    }
}
