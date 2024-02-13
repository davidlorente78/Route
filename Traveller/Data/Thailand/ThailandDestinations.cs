using Data;
using Data.EntityTypes;
using Data.Thailand;
using System.Reflection;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class ThailandDestinations
    {
        public static Destination Mukdahan = new Destination { Name = "Mukdahan" };
        public static Destination NongKhai = new Destination { Name = "Nong Khai" };

        public static Destination PhangNga = new Destination
        {
            CountryId = 3,
            Name = "Phang Nga",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Bangkok = new Destination
        {
            CountryId = 3,
            Name = "Bangkok",
            Picture = "/Bangkok.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination ChiangMai = new Destination
        {
            CountryId = 3,
            Name = "Chiang Mai",
            Picture = "/ChiangMai.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination ChiangRai = new Destination
        {
            CountryId = 3,
            Name = "Chiang Rai",
            Picture = "/ChiangRai.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination HatYai = new Destination
        {
            CountryId = 3,
            Name = "Hat Yai",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Krabi = new Destination
        {
            CountryId = 3,
            Name = "Krabi",
            Picture = "/Krabi.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Phuket = new Destination
        {
            Name = "Phuket",
            CountryId = 3,
            Description = "Phuket, the 'Pearl of the Andaman,' is Thailand's largest and most famous island. Known for its stunning beaches, vibrant nightlife, and rich cultural heritage, Phuket is a top destination for travelers seeking tropical paradise and adventure. Relax on world-class beaches like Patong, Karon, and Kata, where turquoise waters meet golden sands. Explore the vibrant streets of Patong for bustling markets, eclectic shops, and lively entertainment. Discover cultural gems such as the Big Buddha and Wat Chalong, reflecting Phuket's deep-rooted traditions. With a mix of thrilling water activities, vibrant nightlife, and serene cultural experiences, Phuket offers a diverse and unforgettable escape for every type of traveler.",
            Picture = "/Phuket.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Sukhothai = new Destination
        {
            CountryId = 3,
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
            CountryId = 3,
            Name = "Trang",
            Picture = "/Trang.jpg",
            Description = "Trang is a charming province in southern Thailand, known for its picturesque landscapes and rich cultural heritage. The province offers a perfect blend of natural beauty and historical sites. Explore the pristine beaches, such as Hat Chao Mai National Park, with its crystal-clear waters and white sandy shores. Trang is also home to stunning limestone caves, lush jungles, and vibrant local markets. Immerse yourself in the unique local culture and savor delicious Thai cuisine. With its warm hospitality and diverse attractions, Trang is a must-visit destination for travelers seeking an authentic Thai experience.",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
        };

        public static Destination Burinam = new Destination
        {
            CountryId = 3,
            Name = "Burinam",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SungaiKolok = new Destination
        {
            Name = "Su-ngai Kolok",
            LocalName = "สุไหงโกลก",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing },
            Description = "Su-ngai (สุไหงโกลก) is a border town in Narathiwat, Thailand, just north of the Malaysian border. The town on the Malaysian side of the border is Rantau Panjang which is in the state of Kelantan."
        };

        public static Destination PadangPesar = new Destination
        {
            Name = "Padang Pesar - Pekan Siam",
            LocalName = "ڤدڠ بسر",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
        };

        public static Destination ChiangKhong = new Destination
        {
            Name = "Chiang Khong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
        };

        public static Destination Aranyaprathet = new Destination
        {
            Name = "Aranyaprathet",
            LocalName = "อรัญประเทศ",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing },
            Description = "Aranyaprathet is a town (thesaban mueang) in Sa Kaeo province in eastern Thailand . It covers the entire tambon of Aranyaprathet, in Aranyaprathet district. As of 2005, the town has 16,937 inhabitants. It is located just 6 kilometres (3.7 mi) from the border with Cambodia; the town of Poipet is on the other side of the border. On the Thai side of the border is the huge Rongkluea market. Cambodian people cross the border daily with pushcarts and scooters with side cars loaded with their products. A significant part of the trade is in second hand clothes.[1] Just over the border on the Cambodian side there are casinos. These are visited by many Thai people because gambling is prohibited in Thailand.",
            Picture = "/AranyaPrathet.jpg",
        };

        public static Destination VangTao = new Destination
        {
            Name = "Vang Tao",
            Description = "Vang Tao is a hidden gem nestled in the province of Ubon Ratchathani in northeastern Thailand. This tranquil destination offers a serene escape with its lush landscapes and cultural richness. Explore the picturesque surroundings and discover the charm of Vang Tao, known for its peaceful ambiance and natural beauty. The province is home to Pakse Airport, providing convenient access for travelers seeking a quieter retreat. Immerse yourself in the local culture, savor authentic Thai cuisine, and unwind in the tranquil atmosphere that defines Vang Tao. Whether you're interested in exploring nearby attractions or simply relaxing in a peaceful setting, Vang Tao invites you to experience the beauty and tranquility of northeastern Thailand.",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
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
            Description = "Songkhla, a charming city located in southern Thailand, is renowned for its unique blend of cultural heritage, natural beauty, and coastal charm. Nestled along the shores of the Gulf of Thailand, Songkhla offers visitors a delightful mix of historic sites, vibrant markets, and picturesque beaches. Explore the old town with its colonial-era architecture, visit the iconic Mermaid Statue, and stroll through the vibrant Samila Beach. The city is a melting pot of Thai, Chinese, and Malay influences, reflected in its diverse cuisine and cultural traditions. With its inviting atmosphere, friendly locals, and a rich tapestry of experiences, Songkhla is a cap...",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
        };

        public static Destination Chumphon = new Destination
        {
            CountryId = 3,
            Name = "Chumphon",
            Description = "Chumphon, a coastal province in southern Thailand, offers a perfect blend of natural beauty and tranquility. With its pristine beaches, crystal-clear waters, and lush landscapes, Chumphon is a haven for nature enthusiasts and those seeking a peaceful retreat. The province is known for its diverse marine life, making it a popular destination for snorkeling and diving. Explore the scenic coastal areas, such as Hat Sai Ri and Thung Wu",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination HuaHin = new Destination
        {
            CountryId = 3,
            Name = "Hua Hin",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KhonKaen = new Destination
        {
            CountryId = 3,
            Name = "Khon Kaen",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Lampang = new Destination
        {
            CountryId = 3,
            Name = "Lampang",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination MaeHongSon = new Destination
        {
            CountryId = 3,
            Name = "Mae Hong Son",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination MaeSot = new Destination
        {
            CountryId = 3,
            Name = "Mae Sot",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Tak = new Destination
        {
            CountryId = 3,
            Name = "Tak",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonPhanom = new Destination
        {
            CountryId = 3,
            Name = "Nakhon Phanom",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonRatchasima = new Destination
        {
            CountryId = 3,
            Name = "Nakhon Ratchasima",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NanNakhon = new Destination
        {
            CountryId = 3,
            Name = "Nan Nakhon",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Loei = new Destination
        {
            CountryId = 3,
            Name = "Loei",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination NakhonSiThammarat = new Destination
        {
            CountryId = 3,
            Name = "Nakhon Si Thammarat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Narathiwat = new Destination
        {
            CountryId = 3,
            Name = "Narathiwat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Phetchabun = new Destination
        {
            CountryId = 3,
            Name = "Phetchabun",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Phitsanulok = new Destination
        {
            CountryId = 3,
            Name = "Phitsanulok",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Train }
        };

        public static Destination Phrae = new Destination
        {
            CountryId = 3,
            Name = "Phrae",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Ranong = new Destination
        {
            CountryId = 3,
            Name = "Ranong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination RoiEt = new Destination
        {
            CountryId = 3,
            Name = "Roi Et",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SakonNakhon = new Destination
        {
            CountryId = 3,
            Name = "SakonNakhon",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Trat = new Destination
        {
            CountryId = 3,
            Name = "Trat",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination PrachuapKhiriKhan = new Destination
        {
            CountryId = 3,
            Name = "Prachuap Khiri Khan",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SamutPrakan = new Destination
        {
            CountryId = 3,
            Name = "Samut Prakan",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Nonthaburi = new Destination
        {
            CountryId = 3,
            Name = "Nonthaburi",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination PathumThani = new Destination
        {
            CountryId = 3,
            Name = "Pathum Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Betong = new Destination
        {
            CountryId = 3,
            Name = "Betong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Yala = new Destination
        {
            CountryId = 3,
            Name = "Yala",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KoSamui = new Destination
        {
            CountryId = 3,
            Name = "Ko Samui",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination SuratThani = new Destination
        {
            CountryId = 3,
            Name = "Surat Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Rayong = new Destination
        {
            CountryId = 3,
            Name = "Rayong",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Pattaya = new Destination
        {
            CountryId = 3,
            Name = "Pattaya",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination UdonThani = new Destination
        {
            CountryId = 3,
            Name = "Udon Thani",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Lamphun = new Destination
        {
            CountryId = 3,
            Name = "Lamphun",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination KhlongYai = new Destination
        {
            CountryId = 3,
            Name = "Khlong Yai",
            Description = "Close to Chanthaburi",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
        };

        public static Destination BanHatLek = new Destination
        {
            CountryId = 3,
            Name = "Ban Hat Lek",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
        };

        public static List<Destination> CreateDestinationsFromStations()
        {
            List<Destination> destinations = new List<Destination>();

            List<Destination> staticDestinations = GetStaticAll();

            var trainLines = ThailandTrainLines.GetAll();

            foreach (var trainLine in trainLines)
            {
                foreach (var branch in trainLine.Branches)
                {
                    foreach (var station in branch.Stations)
                    {
                        if (!staticDestinations.Where(x => x.Name == station.Name).Any())
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
                            var exist = staticDestinations.Where(x => x.Name == station.Name).FirstOrDefault();

                            exist.DestinationTypes.Add(DestinationTypes.Train);

                        }
                    }
                }
            }

            return destinations;
        }

        public static List<Destination> GetStaticAll()
        {
            var fields = typeof(ThailandDestinations).GetFields(BindingFlags.Static | BindingFlags.Public);

            var destinations = new List<Destination>();

            foreach (var field in fields)
            {
                if (field.FieldType == typeof(Destination))
                {
                    destinations.Add((Destination)field.GetValue(null));
                }
            }

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