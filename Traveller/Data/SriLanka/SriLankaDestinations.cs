using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class SriLankaDestinations
    {
        public static Destination Colombo = new Destination
        {
            Name = "Colombo",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };
    }
}