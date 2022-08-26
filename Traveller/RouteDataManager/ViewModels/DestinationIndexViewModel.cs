using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class DestinationIndexViewModel
    {
        public IEnumerable<Traveller.Domain.Destination> Destinations { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListDestinationTypes{ get; set; }
        public DestinationType FilterDestinationType { get; set; } = new DestinationType() {   DestinationTypeID = 2 };
        public Country FilterCountry { get; set; } = new Country() { CountryID = 3 };

    }
}
