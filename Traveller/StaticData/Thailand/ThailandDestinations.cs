using Domain;
using Data.EntityTypes;
using Data.Thailand;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class ThailandDestinations 
    {
        public static Destination Mukdahan = new Destination { Name = "Mukdahan" };
        public static Destination NongKhai = new Destination { Name = "Nong Khai" };

        public static Destination PhangNga = new Destination
        {
            CountryID = 3,
            Name = "Phang Nga",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Bangkok = new Destination
        {
            CountryID = 3,
            Name = "Bangkok",
            Picture = "/Bangkok.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination ChiangMai = new Destination
        {
            CountryID = 3,
            Name = "Chiang Mai",
            Picture = "/ChiangMai.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination ChiangRai = new Destination
        {
            CountryID = 3,
            Name = "Chiang Rai",
            Picture = "/ChiangRai.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination HatYai = new Destination
        {
            CountryID = 3,
            Name = "Hat Yai",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Krabi = new Destination
        {
            CountryID = 3,
            Name = "Krabi",
            Picture = "/Krabi.jpg",

            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Phuket = new Destination
        {
            Name = "Phuket",
            CountryID = 3,
            Picture = "/Phuket.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Sukhothai = new Destination
        { 
            CountryID = 3,
            Name = "Sukhothai",
            LocalName = "สุโขทัย",
            Description = "Ancient Sukhothai was the first capital of the Sukhothai Kingdom, a long arc of territory that ran through what is today's Laos and western Thailand as far as the Malay states. The kingdom was established in 1238 by Phokhun Si Intharathit, the founder of the Phra Ruang dynasty. It was the state that eventually had the greatest influence on the later Siamese and Thai kingdoms. Traditional Thai history has it that Ramkhamhaeng the Great, the third ruler of the Phra Ruang dynasty, developed the capital at Sukhothai. He is also venerated as being the inventor of the Thai alphabet and being an all-round role model for Thailand's politics, monarchy, and religion. Sukhothai is 12 km west of the modern city of Sukhothai Thani.",
            //Airports = new List<Airport> { ThailandAirports.THS },
            //Stations = new List<Station> { ThailandTrainStations.Phitsanulok },
            Picture = "/Sukhothai.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };
  
        public static Destination Trang = new Destination
        {
            CountryID = 3,
            Name = "Trang",
            Picture = "/Trang.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Burinam = new Destination
        {
            CountryID = 3,
            Name = "Burinam",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SungaiKolok = new Destination
        {
            Name = "Su-ngai Kolok",
            LocalName = "สุไหงโกลก",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier },
            Description = "Su-ngai (สุไหงโกลก) is a border town in Narathiwat, Thailand, just north of the Malaysian border. The town on the Malaysian side of the border is Rantau Panjang which is in the state of Kelantan."
        };

        public static Destination PadangPesar = new Destination
        {
            Name = "Padang Pesar - Pekan Siam",
            LocalName = "ڤدڠ بسر",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }
        };

        public static Destination ChiangKhong = new Destination
        {
            Name = "Chiang Khong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }
        };

        public static Destination Aranyaprathet = new Destination
        {
            Name = "Aranyaprathet",
            LocalName = "อรัญประเทศ",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier },
            Description = "Aranyaprathet is a town (thesaban mueang) in Sa Kaeo province in eastern Thailand . It covers the entire tambon of Aranyaprathet, in Aranyaprathet district. As of 2005, the town has 16,937 inhabitants. It is located just 6 kilometres (3.7 mi) from the border with Cambodia; the town of Poipet is on the other side of the border. On the Thai side of the border is the huge Rongkluea market. Cambodian people cross the border daily with pushcarts and scooters with side cars loaded with their products. A significant part of the trade is in second hand clothes.[1] Just over the border on the Cambodian side there are casinos. These are visited by many Thai people because gambling is prohibited in Thailand.",
            Picture = "/AranyaPrathet.jpg",
             
        };

        public static Destination VangTao = new Destination
        {
            Name = "Vang Tao",
            Description = "In the province of Ubon Ratchathani. Near Pakse airport",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }
        };

        public static Destination UbonRatchathani = new Destination
        {
            Name = "Ubon Ratchathani",
            Description = "Nearest train station to Vang Tao pass",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
        };

        public static Destination Songkhla = new Destination
        {
            Name = "Songkhla",
            Description = "",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
        };

        public static Destination Chumphon = new Destination
        {
            CountryID = 3,
            Name = "Chumphon",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination HuaHin = new Destination
        {
            CountryID = 3,
            Name = "Hua Hin",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KhonKaen = new Destination
        {
            CountryID = 3,
            Name = "Khon Kaen",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Lampang = new Destination
        {
            CountryID = 3,
            Name = "Lampang",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination MaeHongSon = new Destination
        {
            CountryID = 3,
            Name = "Mae Hong Son",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination MaeSot = new Destination
        {
            CountryID = 3,
            Name = "Mae Sot",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Tak = new Destination
        {
            CountryID = 3,
            Name = "Tak",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonPhanom = new Destination
        {
            CountryID = 3,
            Name = "Nakhon Phanom",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonRatchasima = new Destination
        {
            CountryID = 3,
            Name = "Nakhon Ratchasima",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NanNakhon = new Destination
        {
            CountryID = 3,
            Name = "Nan Nakhon",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Loei = new Destination
        {
            CountryID = 3,
            Name = "Loei",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonSiThammarat = new Destination
        {
            CountryID = 3,
            Name = "Nakhon Si Thammarat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Narathiwat = new Destination
        {
            CountryID = 3,
            Name = "Narathiwat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Phetchabun = new Destination
        {
            CountryID = 3,
            Name = "Phetchabun",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Phitsanulok = new Destination
        { 
            CountryID = 3,
            Name = "Phitsanulok",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Train }
        };

        public static Destination Phrae = new Destination
        {
            CountryID = 3,
            Name = "Phrae",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Ranong = new Destination
        {
            CountryID = 3,
            Name = "Ranong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination RoiEt = new Destination
        {
            CountryID = 3,
            Name = "Roi Et",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SakonNakhon = new Destination
        {
            CountryID = 3,
            Name = "SakonNakhon",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Trat = new Destination
        {
            CountryID = 3,
            Name = "Trat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination PrachuapKhiriKhan = new Destination
        {
            CountryID = 3,
            Name = "Prachuap Khiri Khan",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SamutPrakan = new Destination

        {
            CountryID = 3,
            Name = "Samut Prakan",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Nonthaburi = new Destination
        {
            CountryID = 3,
            Name = "Nonthaburi",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination PathumThani = new Destination
        {
            CountryID = 3,
            Name = "Pathum Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Betong = new Destination
        {
            CountryID = 3,
            Name = "Betong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Yala = new Destination
        {
            CountryID = 3,
            Name = "Yala",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KoSamui = new Destination
        {
            CountryID = 3,
            Name = "Ko Samui",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SuratThani = new Destination
        {
            CountryID = 3,
            Name = "Surat Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Rayong = new Destination
        {
            CountryID = 3,
            Name = "Rayong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Pattaya = new Destination
        {
            CountryID = 3,
            Name = "Pattaya",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination UdonThani = new Destination
        {
            CountryID = 3,
            Name = "Udon Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Lamphun = new Destination
        {
            CountryID = 3,
            Name = "Lamphun",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KhlongYai = new Destination
        {
            CountryID = 3,
            Name = "Khlong Yai",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }
        };

        public static Destination BanHatLek = new Destination
        {
            CountryID = 3,
            Name = "Ban Hat Lek",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }
        };

        public static List<Destination> CreateDestinationsFromStations()
        {

            List<Destination> destinations = new List<Destination>();

            List<Destination> staticdestinations = GetStaticAll();

            var trainLines = ThailandTrainLines.GetAll();

            foreach (var trainLine in trainLines)
            {
                foreach (var branch in trainLine.Branches)
                {
                    foreach (var station in branch.Stations)
                    {
                        if (!staticdestinations.Where(x => x.Name == station.Name).Any())
                        {

                            Destination destination = new Destination
                            {
                                Name = station.Name,                                 
                                DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
                            };

                            destinations.Add(destination);
                        }
                        else
                        {
                            var exist = staticdestinations.Where(x => x.Name == station.Name).FirstOrDefault();

                            exist.DestinationTypes.Add(DestinationTypes.Train);

                        }
                    }
                }

            }

            return destinations;

        }

        public static List<Destination> GetStaticAll()
        {
            List<Destination> destinations = new List<Destination> {
                ThailandDestinations.Mukdahan,
                ThailandDestinations.NongKhai,
                ThailandDestinations.PadangPesar,
                ThailandDestinations.SungaiKolok,
                ThailandDestinations.ChiangKhong,
                ThailandDestinations.Aranyaprathet,
                ThailandDestinations.VangTao,
                ThailandDestinations.UbonRatchathani,
                ThailandDestinations.Songkhla,
                ThailandDestinations.Trang,
                ThailandDestinations.Sukhothai,
                ThailandDestinations.Bangkok,
                ThailandDestinations.ChiangMai,
                ThailandDestinations.ChiangRai,
                ThailandDestinations.HatYai,
                ThailandDestinations.Krabi,
                ThailandDestinations.Phuket,
                ThailandDestinations.Sukhothai,
                ThailandDestinations.Trang,
                ThailandDestinations.Burinam,
                ThailandDestinations.Chumphon,
                ThailandDestinations.HuaHin,
                ThailandDestinations.KhonKaen,
                ThailandDestinations.Lampang,
                ThailandDestinations.MaeHongSon,
                ThailandDestinations.MaeSot,
                ThailandDestinations.Tak,
                ThailandDestinations.NakhonPhanom,
                ThailandDestinations.NakhonRatchasima,
                ThailandDestinations.NanNakhon,
                ThailandDestinations.Loei,
                ThailandDestinations.NakhonSiThammarat,
                ThailandDestinations.Narathiwat,
                ThailandDestinations.Phetchabun,
                ThailandDestinations.Phitsanulok,
                ThailandDestinations.Phrae,
                ThailandDestinations.Ranong,
                ThailandDestinations.RoiEt,
                ThailandDestinations.SakonNakhon,
                ThailandDestinations.Trat,
                ThailandDestinations.PrachuapKhiriKhan,
                ThailandDestinations.SamutPrakan,
                ThailandDestinations.Nonthaburi,
                ThailandDestinations.PathumThani,
                ThailandDestinations.Betong,
                ThailandDestinations.Yala,
                ThailandDestinations.KoSamui,
                ThailandDestinations.SuratThani,
                ThailandDestinations.Rayong,
                ThailandDestinations.Pattaya,
                ThailandDestinations.UdonThani,
                ThailandDestinations.Lamphun,
                ThailandDestinations.KhlongYai,
                ThailandDestinations.BanHatLek

            };


            return destinations;

        }

        public static List<Destination> GetAll()

        {
            List<Destination> destinationsFromStatic = GetStaticAll();

            List<Destination> destinationsFromStations = CreateDestinationsFromStations();

            destinationsFromStatic.AddRange(destinationsFromStations);

            return destinationsFromStatic;

        }
    }
}