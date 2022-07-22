using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", DestinationType = DestinationTypes.Frontier,  Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Luang Prabang" };
        public static Destination SopHun = new Destination { Name = "TayTrang - Sop hun ", DestinationType = DestinationTypes.Frontier,  Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Vientiane" };
        public static Destination Vientiane = new Destination { Name = "Vientiane", DestinationType = DestinationTypes.Frontier, Description = "Vientiane" };
        public static Destination Savannakhet = new Destination {  Name = "Savannakhet", DestinationType = DestinationTypes.Frontier,  Description = "Savannakhet" };
        public static Destination LPQ = new Destination { Name = "Luang Prabang Airport", DestinationType = DestinationTypes.Airport,  Description = "Luang Prabang Airport" };
        public static Destination VTE = new Destination { Name = "Wattay International Airport - Vientiane", DestinationType = DestinationTypes.Airport,  Description = "Wattay International Airport - Vientiane" };
        public static Destination PAK = new Destination { Name = "Pakse International Airport(Champasack Province)", DestinationType = DestinationTypes.Airport,  Description = "Pakse International Airport(Champasack Province)" };
        public static Destination LuangPrabang = new Destination { Name = "Luang Prabang", DestinationType = DestinationTypes.Tourism,  Description = "Luang Prabang" };
        public static Destination HuayXai = new Destination { Name = "Huay Xai", DestinationType = DestinationTypes.Frontier,  Description = "Aquí empieza la travesia descendente del Mekong hacia Luang Prabang" };

        public static Destination Dansavanh = new Destination { Name = "Dansavanh", DestinationType = DestinationTypes.Frontier,  Description = "Localidad fronteriza con Vietnam a la misma altura que Savannakhet" };
        public static Destination PhouKeua = new Destination { Name = "Phou Keua", DestinationType = DestinationTypes.Frontier, Description = "Localidad fronteriza con Vietnam a la misma altura que Savannakhet" };

        public static Destination NongKhiang = new Destination { Name = "NongKhiang", DestinationType = DestinationTypes.Frontier,  Description = "Localidad fronteriza más al sur de Laos" };
        public static Destination ChongMek = new Destination { Name = "Chong Mek", DestinationType = DestinationTypes.Frontier,  Description = "Localidad fronteriza cercana a Ubon Ratchathani (Tailandia) y a la localidad de Pakse" };

        public static Destination NamPhao = new Destination { Name = "NamPhao", DestinationType = DestinationTypes.Frontier, Description = "" };
        public static List<Destination> GetAll() {

            List<Destination> destinations = new List<Destination>();
            destinations.Add(Namkan);
            destinations.Add(SopHun);
            destinations.Add(Vientiane);
            destinations.Add(Savannakhet);
            destinations.Add(LPQ);
            destinations.Add(VTE);
            destinations.Add(PAK);
            destinations.Add(LuangPrabang);
            destinations.Add(HuayXai);
            destinations.Add(Dansavanh);
            destinations.Add(PhouKeua);
            destinations.Add(NongKhiang);
            destinations.Add(ChongMek);
            destinations.Add(NamPhao);






            return destinations;



        }


    }
}
