using Application.Dto;
using MassTransit;
using RouteDataManager.Controllers.Generic;
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
