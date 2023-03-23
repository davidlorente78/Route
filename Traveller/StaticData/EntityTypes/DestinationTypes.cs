using Traveller.Domain;

namespace Data.EntityTypes
{
    public static class DestinationTypes
    {

        public static DestinationType BorderCrossing = new DestinationType { Code = 'F', Description = "Border Crossing" };
        public static DestinationType Tourism = new DestinationType { Code = 'T', Description = "Tourism" };
        public static DestinationType Airport = new DestinationType { Code = 'A', Description = "Airport" };
        public static DestinationType Bus = new DestinationType { Code = 'B', Description = "Bus Station" };
        public static DestinationType Train = new DestinationType { Code = 'R', Description = "Train Station" };
    }
}
