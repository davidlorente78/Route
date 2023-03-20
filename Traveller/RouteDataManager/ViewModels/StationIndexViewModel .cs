using Data;
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
        public Traveller.Domain.Country FilterCountry { get; set; } = new Traveller.Domain.Country() { Id = 3 };

    }
}
