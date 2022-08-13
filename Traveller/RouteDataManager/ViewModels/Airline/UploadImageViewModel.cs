using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.Airline
{
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        public IFormFile MapPicture { get; set; }
    }
}
