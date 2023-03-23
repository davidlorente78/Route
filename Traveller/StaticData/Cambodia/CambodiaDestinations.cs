using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        public static Destination Bavet = new Destination { Name = "Bavet", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination PrekChak = new Destination { Name = "Prek Chak", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination KaanSamnor = new Destination { Name = "Kaan Samnor", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        
        public static Destination Poipet = new Destination 
        { 
            Name = "Poipet", 
            LocalName = " ប៉ោយប៉ែត",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } 
        };

        public static Destination Angkor = new Destination { Name = "Angkor", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination Battambang = new Destination { Name = "Battambang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination SiemReap = new Destination { Name = "Siem Reap", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport } };
        public static Destination PhnomPenh = new Destination { Name = "Phnom Penh", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport } };
        public static Destination Sihanoukville = new Destination { Name = "Sihanoukville", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination KamSamnar = new Destination { Name = "K'am Samnar", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination Prom = new Destination { Name = "Prom", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination ChamYeam = new Destination { Name = "Cham Yeam", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination TropaengKreal = new Destination { Name = "Tropaeng Kreal", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };


        public static List<Destination> GetAll()
        {
            List<Destination> destinations = new List<Destination>
            {
                Bavet,
                PrekChak,
                KaanSamnor,
                Poipet,
                Angkor,
                Battambang,
                SiemReap,
                PhnomPenh,
                Sihanoukville,
                KamSamnar,
                Prom,
                ChamYeam,
                TropaengKreal
            };

            return destinations;
        }
    }
}