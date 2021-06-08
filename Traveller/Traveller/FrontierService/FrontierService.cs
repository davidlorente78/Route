using System.Collections.Generic;

namespace Traveller.RouteService
{
    public class FrontierService
    {
       public List<Frontier> FrontierToAccesDestinationFromOrigin(char countryDestination, char countryOrigin)
        {
            Route route = new Route();

            Country origin = route.Countries.Find(x => x.Code == countryOrigin);
            Country destination = route.Countries.Find(x => x.Code == countryDestination);

            var frontiers = destination.Frontiers.FindAll(x => x.Origin.CountryCode == origin.Code);

            return frontiers;

        }


        public List<Frontier> FrontierstoAccesDestinationFromOriginIncludingAirports(char countryDestination, char countryOrigin)
        {
            Route route = new Route();

            Country origin = route.Countries.Find(x => x.Code == countryOrigin);
            Country destination = route.Countries.Find(x => x.Code == countryDestination);

            var frontiers = destination.Frontiers.FindAll(x =>( x.Origin.CountryCode == origin.Code || x.Origin.CountryCode == 'A'));

            return frontiers;

        }

    }
}
