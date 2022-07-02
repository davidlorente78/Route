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
            ///Metodo especifico para Repositorio en Countries. No es del repositorio generico.
            var countries = unitOfWork.Countries.GetCountriesOrderedByName();

            //using LINQ
            return countries.ToList();

        }

    }
}
