using Application.Dto;
using DomainServices.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService : IGenericService<CountryDto, Country>
    {
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}