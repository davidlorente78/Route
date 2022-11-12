using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class FrontiersIndexViewModel
    {
        public IEnumerable<BorderCrossing> Frontiers { get; set; }
        public SelectList SelectListCountriesOrigin { get; set; }
        public SelectList SelectListCountriesFinal { get; set; }
        public SelectList SelectListFrontierTypes{ get; set; }
        public BorderCrossingType FilterFrontierType { get; set; } = new BorderCrossingType() { BorderCrossingTypeID = 2 }; //Terrestrial
        public Country FilterCountryOrigin { get; set; } = new Country() { CountryID = 4 };
        public Country FilterCountryFinal { get; set; } = new Country() { CountryID = 3 };

    }
}
