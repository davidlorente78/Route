using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier },  Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Luang Prabang" };
        public static Destination SopHun = new Destination { Name = "TayTrang - Sop hun ", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Paso terrestre que se usa cuando se llega a Laos desde Hanoi hacia Vientiane" };
        public static Destination Vientiane = new Destination { Name = "Vientiane", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Vientiane" };
        public static Destination Savannakhet = new Destination {  Name = "Savannakhet", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Savannakhet" };
        public static Destination LPQ = new Destination { Name = "Luang Prabang Airport", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "Luang Prabang Airport" };
        public static Destination VTE = new Destination { Name = "Wattay International Airport - Vientiane", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "Wattay International Airport - Vientiane" };
        public static Destination PAK = new Destination { Name = "Pakse International Airport(Champasack Province)", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "Pakse International Airport(Champasack Province)" };
        public static Destination LuangPrabang = new Destination { Name = "Luang Prabang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Luang Prabang" };
        public static Destination HuayXai = new Destination { Name = "Huay Xai", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Aquí empieza la travesia descendente del Mekong hacia Luang Prabang" };

        public static Destination Dansavanh = new Destination { Name = "Dansavanh", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza con Vietnam a la misma altura que Savannakhet" };
        public static Destination PhouKeua = new Destination { Name = "Phou Keua", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza con Vietnam a la misma altura que Savannakhet" };
        public static Destination NongKhiang = new Destination { Name = "NongKhiang", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza más al sur de Laos" };
        public static Destination ChongMek = new Destination { Name = "Chong Mek", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza cercana a Ubon Ratchathani (Tailandia) y a la localidad de Pakse" };
        public static Destination NamPhao = new Destination { Name = "NamPhao", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "" };
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
