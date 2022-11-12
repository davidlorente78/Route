using Domain;
using Domain.Transport.Railway;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class StationIndexViewModel
    {
        public IEnumerable<RailwayStation> Stations { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListLines{ get; set; }
        public RailwayLine FilterLine { get; set; } = new RailwayLine();
        public Country FilterCountry { get; set; } = new Country() { CountryID = 3 };

    }
}
