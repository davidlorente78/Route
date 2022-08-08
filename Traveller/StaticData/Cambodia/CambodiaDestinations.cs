
using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        public static Destination Bavet = new Destination { Name = "Bavet", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination PrekChak = new Destination { Name = "Prek Chak", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination KaanSamnor = new Destination { Name = "Kaan Samnor", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination Poipet = new Destination { Name = "Poipet", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination Angkor = new Destination { Name = "Angkor", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination Battambang = new Destination { Name = "Battambang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination SiemReap = new Destination { Name = "Siem Reap", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport } };
        public static Destination PhnomPenh = new Destination { Name = "Phnom Penh", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport } };
        public static Destination Sihanoukville = new Destination { Name = "Sihanoukville", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static List<Destination> GetAll()
        {

            List<Destination> destinations = new List<Destination>();
            destinations.Add(Bavet);
            destinations.Add(PrekChak);
            destinations.Add(KaanSamnor);
            destinations.Add(Poipet);
            destinations.Add(Angkor);          
            destinations.Add(Battambang);
            destinations.Add(SiemReap);
            destinations.Add(PhnomPenh);
            destinations.Add(Sihanoukville);


            return destinations;



        }
    }
}