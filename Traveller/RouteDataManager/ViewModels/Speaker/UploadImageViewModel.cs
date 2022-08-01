using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.Speaker
{
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        public IFormFile SpeakerPicture { get; set; }
    }
}
