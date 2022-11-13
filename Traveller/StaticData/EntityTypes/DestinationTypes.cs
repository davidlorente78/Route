using Domain.Transport.Aviation;
using Traveller.Domain;

namespace Data.EntityTypes
{
    public static class DestinationTypes
    {

        public static DestinationType Frontier = new DestinationType { Code = 'F', Description = "Frontier" };
        public static DestinationType Tourism = new DestinationType { Code = 'T', Description = "Tourism" };
        public static DestinationType Airport = new DestinationType { Code = 'A', Description = "Airport" };
        public static DestinationType Bus = new DestinationType { Code = 'B', Description = "Bus Station" };
        public static DestinationType Train = new DestinationType { Code = 'R', Description = "Train Station" };
    }

    public static class FrontierTypes
    {
        public static BorderCrossingType Terrestrial = new BorderCrossingType { Code = 'F', Description = "Terrestrial" };
        public static BorderCrossingType Airport = new BorderCrossingType { Code = 'A', Description = "Airport" };
        public static BorderCrossingType Seaports = new BorderCrossingType { Code = 'S', Description = "Sea Port" };
    }

    public static class AirportTypes
    {
        public static AirportType International = new AirportType { Code = 'I', Description = "International" };
        public static AirportType Domestic = new AirportType { Code = 'D', Description = "Domestic" };
        public static AirportType Militar = new AirportType { Code = 'M', Description = "Militar" };
        public static AirportType Other = new AirportType { Code = 'O', Description = "Other" };
    }


}
