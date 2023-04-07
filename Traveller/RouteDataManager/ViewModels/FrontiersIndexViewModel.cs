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
        public BorderCrossingType FilterBorderCrossingType { get; set; } = new BorderCrossingType() { Id = 2 }; //Terrestrial
        public Traveller.Domain.Country FilterCountryOrigin { get; set; } = new Traveller.Domain.Country() { Id = 4 };
        public Traveller.Domain.Country FilterCountryFinal { get; set; } = new Traveller.Domain.Country() { Id = 3 };

    }
}
