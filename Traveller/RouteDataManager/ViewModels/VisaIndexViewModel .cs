using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class VisaIndexViewModel
    {
        public IEnumerable<Visa> Visas { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListNationalities{ get; set; }
        public Nationality FilterNationality { get; set; } = new Nationality() {  NationalityID = 1};
        public Traveller.Domain.Country FilterCountry { get; set; } = new Traveller.Domain.Country() { CountryID = 3 };

    }
}
