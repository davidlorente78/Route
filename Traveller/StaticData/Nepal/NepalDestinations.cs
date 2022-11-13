using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class NepalDestinations
    {
        public static Destination Kathmandu  = new Destination {  CountryID = 7, Name = "Kathmandu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };

    }

}