
using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        //Frontiers
        public static Destination Bavet = new Destination { Name = "Bavet", DestinationType = DestinationTypes.Frontier, CountryCode = 'C' };
        public static Destination PrekChak = new Destination { Name = "Prek Chak", DestinationType = DestinationTypes.Frontier, CountryCode = 'C' };
        public static Destination KaanSamnor = new Destination { Name = "Kaan Samnor", DestinationType = DestinationTypes.Frontier, CountryCode = 'C' };
        public static Destination Poipet = new Destination { Name = "Poipet", DestinationType = DestinationTypes.Frontier, CountryCode = 'C' };



        //Tourist Spots
        public static Destination Angkor = new Destination { Name = "Angkor", DestinationType = DestinationTypes.Tourism, CountryCode = 'C' };
        public static Destination REP = new Destination { Name = "Siem Reap International Airport", DestinationType = DestinationTypes.Airport, CountryCode = 'C' };
        public static Destination Battambang = new Destination { Name = "Battambang", DestinationType = DestinationTypes.Tourism, CountryCode = 'C' };
        public static List<Destination> GetAll()
        {

            List<Destination> destinations = new List<Destination>();
            destinations.Add(Bavet);
            destinations.Add(PrekChak);
            destinations.Add(KaanSamnor);
            destinations.Add(Poipet);

            destinations.Add(Angkor);
            destinations.Add(REP);
            destinations.Add(Battambang);


            return destinations;



        }
    }
}