using Data.EntityTypes;
using Domain.Transport.Aviation;
using Traveller.Domain;

namespace Data.Utils
{
    public static class BorderCrossingUtils
    {
        public static List<BorderCrossing> CreateFrontiersFromInternationalAirports(ICollection<Airport> airports, ICollection<Visa> visas)
        {
            List<BorderCrossing> frontiers = new List<BorderCrossing>();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {
                BorderCrossing frontierFromAirport = new BorderCrossing()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    DestinationOrigin = airport.Destinations.FirstOrDefault(),
                    DestinationFinal = airport.Destinations.FirstOrDefault(),
                    BorderCrossingType = BorderCrossingTypes.Airport,
                    Visas = visas,
                };

                frontiers.Add(frontierFromAirport);
            }

            return frontiers;
        }
    }
}
