using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService
    {
        ICollection<Country> GetAllCountries();
    }
}