using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class NepalDestinations
    {
        public static Destination KTM = new Destination { Name = "Tribhuvan International Airport", DestinationType = DestinationTypes.Airport, CountryCode = 'N', Description = "Katmandu International Airport" };
    }

}