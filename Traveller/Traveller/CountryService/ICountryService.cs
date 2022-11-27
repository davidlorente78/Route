using System.Collections.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService
    {
        ICollection<CountryDto> GetAllCountries();
        CountryDto GetCountryByID(int ID);
        bool CountryExists(int id);
        int AddCountry(Country country);
        int RemoveCountry(CountryDto countryDto);
        int UpdateCountry(Country country);
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}