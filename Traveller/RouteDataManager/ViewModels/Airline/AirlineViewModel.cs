using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.Airline
{
    public class AirlineViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string? IATACode { get; set; }
        public string? LocalName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Airline Type")]
        public int AirlineTypeID { get; set; }
        public SelectList SelectListAirlineTypes { get; set; }
    }
}
