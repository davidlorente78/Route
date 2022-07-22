using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalaysiaDestinations
    {


        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", DestinationType = DestinationTypes.Frontier };
        public static Destination RantanPanjang = new Destination { Name = "Rantan Panjang", DestinationType = DestinationTypes.Frontier };
        public static Destination KotaBahru = new Destination { Name = "Kota Bahru", DestinationType = DestinationTypes.Frontier };
        public static Destination Penang = new Destination { Name = "Penang", DestinationType = DestinationTypes.Frontier };
        public static Destination KUL = new Destination { Name = "Kuala Lumpur Airport", DestinationType = DestinationTypes.Airport };
        public static Destination JohorBahru = new Destination { Name = "Johor Bahru", DestinationType = DestinationTypes.Frontier };

        public static Destination Butterworth = new Destination { Name = "Butterworth", DestinationType = DestinationTypes.Tourism };
        public static Destination KualaLumpur = new Destination { Name = "Kuala Lumpur", DestinationType = DestinationTypes.Tourism };

        public static Destination KualaKangsar = new Destination { Name = "Kuala Kangsar", DestinationType = DestinationTypes.Tourism };
        public static Destination Ipoh = new Destination { Name = "Ipoh", DestinationType = DestinationTypes.Tourism };
        public static ICollection<Destination> GetAll()
        {
            return new List<Destination> {
                MalaysiaDestinations.KualaLumpur,
                MalaysiaDestinations.RantanPanjang,
                MalaysiaDestinations.PadangPesar,
                MalaysiaDestinations.KualaLumpur,
                MalaysiaDestinations.Penang,
                MalaysiaDestinations.Butterworth,
                MalaysiaDestinations.KotaBahru,
                MalaysiaDestinations.KUL,
                MalaysiaDestinations.JohorBahru,

                //Train
                MalaysiaDestinations.KualaKangsar,
                MalaysiaDestinations.Ipoh
            
            };
        
        }
    }
}
