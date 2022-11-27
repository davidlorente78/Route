using Domain.Transport.Aviation;
using Traveller.Domain;

namespace Data.EntityTypes
{
    public static class AirlineTypes
    {
        public static AirlineType Scheduled = new AirlineType { Code = 'S', Description = "Scheduled" };
        public static AirlineType Charter = new AirlineType { Code = 'C', Description = "Charter" };
        public static AirlineType Budget = new AirlineType { Code = 'L', Description = "Budget" };
    }



}
