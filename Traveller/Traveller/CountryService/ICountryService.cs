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
        int AddCountry(CountryDto countryDto);
        int RemoveCountry(int id);
        int UpdateCountry(CountryDto countryDto);
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}