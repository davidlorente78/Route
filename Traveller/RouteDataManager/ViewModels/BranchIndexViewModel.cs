using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class BranchIndexViewModel
    {
        public IEnumerable<Branch> Branches { get; set; }
        public SelectList SelectListCountries { get; set; }
        public Country FilterCountry { get; set; } = new Country() { CountryID = 3 };

    }
}
