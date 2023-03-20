using System.Collections.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface ICountryService
    {
        ICollection<CountryDto> GetAll();
        CountryDto GetByID(int ID);
        bool Exists(int id);
        int Add(CountryDto countryDto);
        int Remove(int id);
        int Update(CountryDto countryDto);
        public Country GetCountryIncludingRangesByCountryCode(char CountryCode);
    }
}