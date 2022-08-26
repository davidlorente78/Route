using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

//TODO REFACTOR
namespace RouteDataManager.ViewModels.Destination
{
    public class UploadImageViewModel    {
      
        public IFormFile Picture { get; set; }
    }
}
