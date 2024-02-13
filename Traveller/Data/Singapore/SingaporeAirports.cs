using Data.EntityTypes;
using Domain.Transport.Aviation;

namespace Data.Nepal
{
    public static class SingaporeAirports
    {
        public static Airport SIN = new Airport
        {
            Name = "Singapore Changi Airport",
            IATACode = "SIN",
            ICAOCode = "WSSS",
            AirportType = AirportTypes.International
        };

        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                SIN
            };
        }
    }
}
