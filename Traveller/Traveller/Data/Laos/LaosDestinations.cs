using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Data
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", Type = 'F', CountryCode ='L', Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Luang Prabang" };
        public static Destination Taichang = new Destination { Name = "TayTrang - Taichang ", Type = 'F', CountryCode = 'L', Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Vientiane" };
        public static Destination Vientiane = new Destination { Name = "Vientiane", Type = 'F', CountryCode = 'L', };
        public static Destination Savannakhet = new Destination { Name = "Savannakhet", Type = 'F', CountryCode = 'L', };
        public static Destination LPQ = new Destination { Name = "Luang Prabang Airport", Type = 'F', CountryCode = 'L', };
        public static Destination VTE = new Destination { Name = "Wattay Airport - Vientiane", Type = 'F', CountryCode = 'L', };
        public static Destination PAK = new Destination { Name = "Pakse International Airport(Champasack Province)", Type = 'F', CountryCode = 'L', };
        public static Destination LuangPrabang = new Destination { Name = "Luang Prabang South Bus Station", Type = 'F', CountryCode  = 'L', };
    }
}
