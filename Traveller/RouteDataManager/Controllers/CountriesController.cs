using Application.Dto;
using RouteDataManager.Controllers.Generic;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class CountriesController : GenericController<CountryDto, Country>
    {
        public CountriesController(ICountryService countryService) : base(countryService)
        {
        }
    }
}
