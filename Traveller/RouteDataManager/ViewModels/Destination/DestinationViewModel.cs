using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.Destination
{
    public class DestinationViewModel : EditImageViewModel
    {
        public int DestinationID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryID { get; set; }
        public int DestinationTypeID { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListDestinationTypes { get; set; }
    }
}
