using Domain.Transport.Aviation;

namespace Data.EntityTypes
{
    public static class AirportTypes
    {
        public static AirportType International = new AirportType { Code = 'I', Description = "International" };
        public static AirportType Domestic = new AirportType { Code = 'D', Description = "Domestic" };
        public static AirportType Militar = new AirportType { Code = 'M', Description = "Militar" };
        public static AirportType Other = new AirportType { Code = 'O', Description = "Other" };
    }
}
