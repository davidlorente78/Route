using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Laos
{
    public static class LaosAirports
    {
        
        public static Airport VTE = new Airport
        {
            Name = "Wattay International Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.Vientiane },
            IATACode = "VTE",
            AirportType = AirportTypes.International
        };

        public static Airport LPQ = new Airport
        {
            Name = "Luang Prabrang International Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.LuangPrabang },
            IATACode = "LPQ",
            AirportType = AirportTypes.International
        };

        public static Airport PKZ = new Airport
        {
            Name = "Pakse Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.Pakse },
            IATACode = "PKZ",
            AirportType = AirportTypes.International
        };

        public static Airport HOE = new Airport
        {
            Name = "Ban Huoeisay Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.HuayXai },
            IATACode = "HOE",
            AirportType = AirportTypes.Domestic
        };

        public static Airport LXG = new Airport
        {
            Name = "Luang Namtha Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.LuangNamtha },
            IATACode = "LXG",
            AirportType = AirportTypes.Domestic
        };
        public static Airport ODY = new Airport
        {
            Name = "Oudomsay Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.Oudomsay },
            IATACode = "ODY",
            AirportType = AirportTypes.Domestic
        };

        public static Airport XKH = new Airport
        {
            Name = "Xieng Khouang Airport",
            ServingDestinations = new List<Destination> { LaosDestinations.XiengKhouang },
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
