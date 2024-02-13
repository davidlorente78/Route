using Domain.Transport.Aviation;
using Data.EntityTypes;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Laos
{
    public static class LaosAirports
    {
        public static Airport VTE = new Airport
        {
            Name = "Wattay International Airport",
            Destinations = new List<Destination> { LaosDestinations.Vientiane },
            Description = "Wattay International Airport is the main international airport serving Vientiane, the capital city of Laos. It is located about 3.5 kilometers (2.2 miles) outside of the city center and is named after the village of Wattay, which was located on the airport site before its construction.\r\n\r\nThe airport has a single terminal building and two runways, one of which is paved and the other is unpaved. It has a capacity of handling approximately 1.5 million passengers per year.\r\n\r\nThe airport offers both domestic and international flights, with several airlines operating regular flights to destinations such as Bangkok, Hanoi, Ho Chi Minh City, Kunming, Seoul, Singapore, and Taipei. It also serves as a hub for Lao Airlines, the national carrier of Laos.\r\n\r\nFacilities at the airport include a variety of restaurants and cafes, duty-free shopping, ATMs, currency exchange, and car rental services. There are also VIP lounges available for passengers who require a more exclusive and comfortable experience.\r\n\r\nOverall, Wattay International Airport is a modern and efficient airport that serves as an important gateway to Laos for international travelers.",
            IATACode = "VTE",
            AirportType = AirportTypes.International
        };

        public static Airport LPQ = new Airport
        {
            Name = "Luang Prabrang International Airport",
            Description = "Luang Prabang International Airport is an international airport located in the northern city of Luang Prabang in Laos. The airport is situated about 4 kilometers (2.5 miles) from the city center and serves as an important gateway to one of the most popular tourist destinations in Laos.\r\n\r\nThe airport has a single terminal building and a single runway that is capable of handling aircraft up to the size of an Airbus A320. It has the capacity to handle approximately 700,000 passengers per year.\r\n\r\nLuang Prabang International Airport offers both domestic and international flights, with airlines operating regular services to destinations such as Bangkok, Chiang Mai, Hanoi, Kunming, Seoul, Siem Reap, and Singapore.\r\n\r\nFacilities at the airport include a variety of restaurants and cafes, duty-free shopping, ATMs, currency exchange, and car rental services. There are also VIP lounges available for passengers who require a more exclusive and comfortable experience.\r\n\r\nOverall, Luang Prabang International Airport is a modern and efficient airport that provides a convenient access point for visitors to the charming city of Luang Prabang and the surrounding region.",
            Destinations = new List<Destination> { LaosDestinations.LuangPrabang },
            IATACode = "LPQ",
            AirportType = AirportTypes.International
        };

        public static Airport PKZ = new Airport
        {
            Name = "Pakse Airport",
            Destinations = new List<Destination> { LaosDestinations.Pakse },
            IATACode = "PKZ",
            AirportType = AirportTypes.International
        };

        public static Airport HOE = new Airport
        {
            Name = "Ban Huoeisay Airport",
            Destinations = new List<Destination> { LaosDestinations.HuayXai },
            IATACode = "HOE",
            AirportType = AirportTypes.Domestic
        };

        public static Airport LXG = new Airport
        {
            Name = "Luang Namtha Airport",
            Destinations = new List<Destination> { LaosDestinations.LuangNamtha },
            IATACode = "LXG",
            AirportType = AirportTypes.Domestic
        };

        public static Airport ODY = new Airport
        {
            Name = "Oudomsay Airport",
            Destinations = new List<Destination> { LaosDestinations.Oudomsay },
            IATACode = "ODY",
            AirportType = AirportTypes.Domestic
        };

        public static Airport XKH = new Airport
        {
            Name = "Xieng Khouang Airport",
            Destinations = new List<Destination> { LaosDestinations.XiengKhouang },
            IATACode = "XKH",
            AirportType = AirportTypes.Domestic
        };

        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                VTE,LPQ,PKZ,HOE,LXG,ODY,XKH
            };
        }
    }
}
