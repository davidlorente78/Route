using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.RailwaySystem
{
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        public IFormFile MapPicture { get; set; }
    }
}
