using DomainServices.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService : IGenericService<CountryDto, Country>
    {
        public Country GetByCode(char countryCode);

        public Country GetByCodeIncludingRanges(char countryCode);
    }
}