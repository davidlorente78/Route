using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService
    {
        ICollection<Country> GetAllCountries();
        Country GetCountryByID(int ID);
        bool CountryExists(int id);

        int AddCountry(Country country);
        int RemoveCountry(Country country);
        int UpdateCountry(Country country);
    }
}