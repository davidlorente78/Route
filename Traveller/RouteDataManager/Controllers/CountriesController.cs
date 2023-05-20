using MassTransit;
using RouteDataManager.Controllers.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class CountriesController : GenericController<CountryDto, Country>
    {
        public CountriesController(ICountryService countryService
            , IPublishEndpoint publishEndpoint) : base(countryService, publishEndpoint)
        {
        }
    }
}
