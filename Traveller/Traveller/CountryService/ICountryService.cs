using System.Collections.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService
    {
        ICollection<Country> GetAllCountries();
        Country GetCountryByID(int ID);
        CountryDto GetCountry(int ID);
        bool CountryExists(int id);
        int AddCountry(Country country);
        int RemoveCountry(Country country);
        int UpdateCountry(Country country);
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}