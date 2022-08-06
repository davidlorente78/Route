using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class AirportIndexViewModel
    {
        public IEnumerable<Airport> Airports { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListAirportTypes{ get; set; }

        public AirportType FilterAirportType { get; set; } = new AirportType() {   AirportTypeID = 1 };
        public Country FilterCountry { get; set; } = new Country() { CountryID = 1 };

    }
}
