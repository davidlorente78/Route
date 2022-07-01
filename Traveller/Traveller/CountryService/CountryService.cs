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


        //TODO Check if List is appropiate
        public ICollection<Country> GetAllCountries()
        {
            var countries = unitOfWork.Countries.GetAll();

            //using LINQ
            return countries.ToList();

        }

    }
}
