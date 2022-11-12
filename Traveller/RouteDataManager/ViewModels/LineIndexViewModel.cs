using Domain;
using Domain.Transport.Railway;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class LineIndexViewModel
    {
        public IEnumerable<RailwayLine> Lines { get; set; }
        public SelectList SelectListCountries { get; set; }
        public Country FilterCountry { get; set; } = new Country() { CountryID = 3 };

    }
}
