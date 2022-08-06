
using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        //Frontiers
        public static Destination Bavet = new Destination { Name = "Bavet", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination PrekChak = new Destination { Name = "Prek Chak", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination KaanSamnor = new Destination { Name = "Kaan Samnor", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination Poipet = new Destination { Name = "Poipet", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };

        //Tourist Spots
        public static Destination Angkor = new Destination { Name = "Angkor", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination REP = new Destination { Name = "Siem Reap International Airport", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination Battambang = new Destination { Name = "Battambang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
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