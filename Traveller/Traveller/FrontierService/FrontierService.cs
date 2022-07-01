using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;
using Traveller.StaticData;

namespace Traveller.DomainServices
{
    public class FrontierService {

        private IUnitOfWork unitOfWork;
        public FrontierService(IUnitOfWork unitOfWork) {
    
         this.unitOfWork = unitOfWork;
    
    }
    
        public List<Frontier> FrontierToAccesDestinationFromOrigin(char countryDestination, char countryOrigin)
        {

            //ICollection<Country> origin = unitOfWork.Countries.Find(x => x.Code == countryOrigin);
            //ICollection<Country> destination = unitOfWork.Countries.Find(x => x.Code == countryDestination).ToList();

            //destination[0].

            //Route route = new Route(); //Old Static Data
            //Country origin = route.Countries.Find(x => x.Code == countryOrigin);
            //Country destination = route.Countries.Find(x => x.Code == countryDestination);
            //var frontiers = destination(0).Frontiers.FindAll(x => x.Origin.CountryCode == origin.Code);

            return new List<Frontier>(); //TODO

        }


        //public List<Frontier> FrontierstoAccesDestinationFromOriginIncludingAirports(char countryDestination, char countryOrigin)
        //{
        //    Route route = new Route();

        //    Country origin = route.Countries.Find(x => x.Code == countryOrigin);
        //    Country destination = route.Countries.Find(x => x.Code == countryDestination);

        //    var frontiers = destination.Frontiers.FindAll(x =>( x.Origin.CountryCode == origin.Code || x.Origin.CountryCode == 'A'));

        //    return frontiers;

        //}

    }
}
