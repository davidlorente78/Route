using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", Type = 'F', CountryCode = 'L', Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Luang Prabang" };
        public static Destination Taichang = new Destination { Name = "TayTrang - Taichang ", Type = 'F', CountryCode = 'L', Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Vientiane" };
        public static Destination Vientiane = new Destination { Name = "Vientiane", Type = 'F', CountryCode = 'L', Description = "Vientiane" };
        public static Destination Savannakhet = new Destination {  Name = "Savannakhet", Type = 'F', CountryCode = 'L', Description = "Savannakhet" };
        public static Destination LPQ = new Destination { Name = "Luang Prabang Airport", Type = 'F', CountryCode = 'L', Description = "Luang Prabang Airport" };
        public static Destination VTE = new Destination { Name = "Wattay Airport - Vientiane", Type = 'F', CountryCode = 'L', Description = "Wattay Airport - Vientiane" };
        public static Destination PAK = new Destination { Name = "Pakse International Airport(Champasack Province)", Type = 'F', CountryCode = 'L', Description = "Pakse International Airport(Champasack Province)" };
        public static Destination LuangPrabang = new Destination { Name = "Luang Prabang South Bus Station", Type = 'F', CountryCode = 'L', Description = "Luang Prabang South Bus Station" };



        public static List<Destination> GetAll() {

            List<Destination> destinations = new List<Destination>();
            destinations.Add(Namkan);
            destinations.Add(Taichang);
            destinations.Add(Vientiane);
            destinations.Add(Savannakhet);
            destinations.Add(LPQ);
            destinations.Add(VTE);
            destinations.Add(PAK);
            destinations.Add(LuangPrabang);

            return destinations;



        }


    }
}
