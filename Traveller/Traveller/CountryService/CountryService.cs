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


        //TODO Check if List is appropiate
        public ICollection<Country> GetAllCountries()
        {
            ///Metodo especifico para Repositorio en Countries. No es del repositorio generico.
            var countries = unitOfWork.Countries.GetCountriesOrderedByName();

            //using LINQ
            return countries.ToList();

        }

        public Country GetCountryByID(int ID)
        {
            //Metodo del repositorio generico 
            //Aqui no hay include de las entidades asociadas
            //var country= unitOfWork.Countries.GetById(ID);

            //Metodo del repositorio concreto HERE
            var country = unitOfWork.Countries.GetCountryByID(ID);

            //Warning ICollection o solo una entidad

            return country.First();

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
