using Domain.Transport.Aviation;
using Data.EntityTypes;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Cambodia
{
    public static class CambodiaAirports
    {
        
        public static Airport REP = new Airport("Siem Reap International Airport", "REP", AirportTypes.International)
        {          
            Destinations = new List<Destination> { CambodiaDestinations.SiemReap },           
        };

        public static Airport PNH = new Airport("Phnom Penh International Airport", "PNH", AirportTypes.International)
        {         
            Destinations = new List<Destination> { CambodiaDestinations.PhnomPenh },           
        };

        public static Airport KOS = new Airport("Sihanoukville International Airport", "KOS", AirportTypes.International)
        {           
            Destinations = new List<Destination> { CambodiaDestinations.Sihanoukville },          
        };
 
        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                REP,PNH,KOS
            };
        }
    }
}
