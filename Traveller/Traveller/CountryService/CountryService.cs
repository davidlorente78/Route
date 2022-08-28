using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class CountryService : ICountryService
    {
        private IUnitOfWork unitOfWork;
        public CountryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool CountryExists(int id)
        {
            return (unitOfWork.Countries?.Find(e => e.CountryID == id)).Count() != 0;
        }

        public ICollection<Country> GetAllCountries()
        {
            var countries = unitOfWork.Countries.GetCountriesOrderedByName();

            return countries.ToList();

        }

        public Country GetCountryByID(int ID)
        {           
            var country = unitOfWork.Countries.GetCountryByID(ID);

            return country.First();

        }

        public Country GetCountryRangesByCode(char CountryCode)
        {            
            var country = unitOfWork.Countries.GetCountryRangesByCode(CountryCode);

            return country;
        }

        public int AddCountry(Country country)
        {            
           unitOfWork.Countries.Add(country);
           return unitOfWork.Complete();

        }

        public int RemoveCountry(Country country)
        {
            unitOfWork.Countries.Remove(country);
            return unitOfWork.Complete();
        }

        public int UpdateCountry(Country country)
        {
            unitOfWork.Countries.Update(country);
            //Needed to save changes ¿?
            return unitOfWork.Complete();
        }


    }
}
