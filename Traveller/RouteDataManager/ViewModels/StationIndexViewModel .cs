using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class StationIndexViewModel
    {
        public IEnumerable<Station> Stations { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListLines{ get; set; }
        public Line FilterLine { get; set; } = new Line();
        public Country FilterCountry { get; set; } = new Country() { CountryID = 3 };

    }
}
