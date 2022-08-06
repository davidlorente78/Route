using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class NepalDestinations
    {
        public static Destination KTM = new Destination { Name = "Tribhuvan International Airport", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "Katmandu International Airport"  };
    }

}