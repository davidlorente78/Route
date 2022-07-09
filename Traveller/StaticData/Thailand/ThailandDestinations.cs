using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class ThailandDestinations
    {
        public static Destination Mukdahan = new Destination { Name = "Mukdahan", CountryCode = 'T' };
        public static Destination NongKhai = new Destination { Name = "Nong Khai", CountryCode = 'T' };

        public static Destination BKK = new Destination { Name = "Bangkok Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination CNX = new Destination { Name = "Chiang Mai Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination CEI = new Destination { Name = "Chiang Rai Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination HDY = new Destination { Name = "Hat Yai Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination KBV = new Destination { Name = "Krabi Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination HKT = new Destination { Name = "Phuket Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination THS = new Destination { Name = "Sukhothai Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };
        public static Destination TST = new Destination { Name = "Trang Airport", CountryCode = 'T', DestinationType = DestinationTypes.Airport };







        public static Destination SungaiKolok = new Destination { Name = "Sungai Kolok", CountryCode = 'T', DestinationType = DestinationTypes.Frontier };
        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", CountryCode = 'T' , DestinationType = DestinationTypes.Frontier };
        public static Destination ChiangKhong = new Destination { Name = "Chiang Khong ", CountryCode = 'T', DestinationType = DestinationTypes.Frontier };
        public static Destination Aranyaprathet = new Destination { Name = "Aranya Prathet", CountryCode = 'T', DestinationType = DestinationTypes.Frontier };
        public static Destination VangTao = new Destination { Name = "Vang Tao", CountryCode = 'T',  Description = "En la provincia de Ubon Ratchathani. Cercano al aeropuerto de Pakse" ,DestinationType = DestinationTypes.Frontier };
        public static Destination UbonRatchathani = new Destination { Name = "Ubon Ratchathani", CountryCode = 'T', Description = "Estacion de tren más cercana al paso de Vang Tao", DestinationType = DestinationTypes.Train };

        public static ICollection<Destination> GetAll()
        {
            return new List<Destination> {
                ThailandDestinations.Mukdahan,
                ThailandDestinations.NongKhai,
                ThailandDestinations.PadangPesar,
                ThailandDestinations.SungaiKolok,
                ThailandDestinations.ChiangKhong,
                ThailandDestinations.Aranyaprathet ,
                ThailandDestinations.VangTao,
                ThailandDestinations.UbonRatchathani,
                ThailandDestinations.BKK, CNX,CEI,HDY,KBV,HKT,THS,TST


            };
             
        }
    }
}