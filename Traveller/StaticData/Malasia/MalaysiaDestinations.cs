using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalaysiaDestinations
    {


        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination RantanPanjang = new Destination { Name = "Rantan Panjang", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination KotaBahru = new Destination { Name = "Kota Bahru", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };
        public static Destination Penang = new Destination {  CountryID=4, Name = "Penang", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier, DestinationTypes.Airport } };
        public static Destination KUL = new Destination { Name = "Kuala Lumpur Airport", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination JohorBahru = new Destination { CountryID = 4, Name = "Johor Bahru", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier , DestinationTypes.Airport } };

        public static Destination Butterworth = new Destination { Name = "Butterworth", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination KualaLumpur = new Destination { CountryID = 4, Name = "Kuala Lumpur", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination KualaKangsar = new Destination { Name = "Kuala Kangsar", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination Ipoh = new Destination { Name = "Ipoh", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport} };

        public static Destination KotaKinabalu = new Destination { Name = "Kota Kinabalu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination Langkawi = new Destination { Name = "Langkawi", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination Kuching = new Destination { Name = "Kuching", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination AlorSatar = new Destination { Name = "Alor Satar", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination KotaBaharu = new Destination { Name = "Kota Baharu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination KualaTerengganu = new Destination { Name = "KKuala Terengganu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static Destination Subang = new Destination { Name = "Subang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };


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
                MalaysiaDestinations.KotaKinabalu,
                MalaysiaDestinations.Langkawi,
                MalaysiaDestinations.Kuching,
                MalaysiaDestinations.AlorSatar,
                MalaysiaDestinations.KotaBaharu,
                MalaysiaDestinations.KualaTerengganu,
                MalaysiaDestinations.Subang,                     
                MalaysiaDestinations.KualaKangsar,
                MalaysiaDestinations.Ipoh

            };

        }
    }
}
