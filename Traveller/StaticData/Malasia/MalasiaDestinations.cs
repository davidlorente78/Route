using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalasiaDestinations
    {

        public static Destination Butterworth = new Destination { Name = "Butterworth", DestinationType = DestinationTypes.Tourism, CountryCode = 'M', };
        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", DestinationType = DestinationTypes.Frontier, CountryCode = 'M', };
        public static Destination RantanPanjang = new Destination { Name = "Rantan Panjang", DestinationType = DestinationTypes.Frontier, CountryCode = 'M', };
        public static Destination KotaBahru = new Destination { Name = "Kota Bahru", DestinationType = DestinationTypes.Frontier, CountryCode = 'M', };
        public static Destination Penang = new Destination { Name = "Penang", DestinationType = DestinationTypes.Frontier, CountryCode = 'M', };
        public static Destination KualaLumpur = new Destination { Name = "Kuala Lumpur", DestinationType = DestinationTypes.Tourism, CountryCode = 'M', };
        public static Destination KUL = new Destination { Name = "Kuala Lumpur Airport", DestinationType = DestinationTypes.Airport, CountryCode = 'M' };
        public static Destination JohorBahru = new Destination { Name = "Johor Bahru", DestinationType = DestinationTypes.Frontier, CountryCode = 'M' };

        public static ICollection<Destination> GetAll()
        {
            return new List<Destination> {
                MalasiaDestinations.KualaLumpur,
                MalasiaDestinations.RantanPanjang,
                MalasiaDestinations.PadangPesar,
                MalasiaDestinations.KualaLumpur,
                MalasiaDestinations.Penang,
                MalasiaDestinations.Butterworth,
                MalasiaDestinations.KotaBahru,
                MalasiaDestinations.KUL,
                MalasiaDestinations.JohorBahru };
        
        }
    }
}
