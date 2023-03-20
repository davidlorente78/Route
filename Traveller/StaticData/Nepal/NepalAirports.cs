using Data.EntityTypes;
using Domain.Transport.Aviation;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nepal
{
    public static class NepalAirports
    {
        //Los 9 aeropuertos más grandes en Nepal
        //IATA    Nombre Paraje  Aerolíneas Destinos
        //KTM Tribhuvan International Airport Kathmandu	27	32
        public static Airport KTM = new Airport
        {
            Name = "Tribhuvan International Airport",
            Destinations = new List<Destination> { NepalDestinations.Kathmandu },
            IATACode = "KTM",
            AirportType = AirportTypes.International
        };

        //BHR Bharatpur Airport Bharatpur	1	1
        //BWA Gautam Buddha Airport   Bhairawa	1	1
        //BDP Bhadrapur Airport Bhadrapur	1	1
        //JKR Janakpur Airport Janakpur	1	1
        //KEP Nepalgunj Airport Nepalgunj	1	1
        //PKR Pokhara Airport Pokhara	1	1
        //TMI Tumling Tar Airport Tumling Tar	1	1
        //BIR Biratnagar Airport Biratnagar	1	1

        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                KTM
            };
        }
    }
}
