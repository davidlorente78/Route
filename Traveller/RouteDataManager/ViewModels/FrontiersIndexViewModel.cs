using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class BorderCrossingsIndexViewModel
    {
        public IEnumerable<BorderCrossing> BorderCrossings { get; set; }
        public SelectList SelectListCountriesOrigin { get; set; }
        public SelectList SelectListCountriesFinal { get; set; }
        public SelectList SelectListBorderCrossingTypes { get; set; }
        public BorderCrossingType FilterBorderCrossingType { get; set; } = new BorderCrossingType() { BorderCrossingTypeID = 2 }; //Terrestrial
        public Country FilterCountryOrigin { get; set; } = new Country() { CountryID = 4 };
        public Country FilterCountryFinal { get; set; } = new Country() { CountryID = 3 };

    }
}
