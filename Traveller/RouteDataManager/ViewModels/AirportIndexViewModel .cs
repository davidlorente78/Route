using Domain.Transport.Aviation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RouteDataManager.ViewModels
{
    public class AirportIndexViewModel
    {
        public IEnumerable<Airport> Airports { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListAirportTypes { get; set; }

        public AirportType FilterAirportType { get; set; } = new AirportType() { AirportTypeID = 1 };
        public Traveller.Domain.Country FilterCountry { get; set; } = new Traveller.Domain.Country() { Id = 1 };

    }
}
