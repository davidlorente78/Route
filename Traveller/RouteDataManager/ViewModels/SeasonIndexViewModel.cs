using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class Month_EntityByCountryIndexViewModel
    {
        public Dictionary<string, string> Month_EntityDescription { get; set; } = new Dictionary<string, string>();
        public SelectList SelectListCountries { get; set; }
        public Traveller.Domain.Country FilterCountry { get; set; } = new Traveller.Domain.Country() { Id = 1 };

    }
}
