using DomainServices.GenericService;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService : IGenericService<CountryDto, Country>
    {
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}