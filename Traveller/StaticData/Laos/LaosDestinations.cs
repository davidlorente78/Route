using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Land crossing used when arriving in Laos from Hanoi to Luang Prabang" };
        public static Destination SopHun = new Destination { Name = "Tay Trang - Sop hun ", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Land crossing used when arriving in Laos from Hanoi to Vientiane" };
        public static Destination Vientiane = new Destination { CountryId = 1, Name = "Vientiane", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing, DestinationTypes.Airport }, Description = "Vientiane" };
        public static Destination Savannakhet = new Destination { Name = "Savannakhet", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Savannakhet" };
        public static Destination LuangPrabang = new Destination { CountryId = 1, Name = "Luang Prabang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }, Description = "Luang Prabang" };
        public static Destination HuayXai = new Destination { CountryId = 1, Name = "Huay Xai", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing, DestinationTypes.Airport, DestinationTypes.Tourism }, Description = "Here begins the downstream crossing of the Mekong to Luang Prabang." };
        public static Destination Dansavanh = new Destination { Name = "Dansavanh", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Border Village with Vietnam near Savannakhet." };
        public static Destination PhouKeua = new Destination { Name = "Phou Keua", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Border Village with Vietnam near Savannakhet." };
        public static Destination NongKhiang = new Destination { Name = "Nong Khiang", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Southernmost border town in Laos" };
        public static Destination ChongMek = new Destination { Name = "Chong Mek", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Border town near Ubon Ratchathani (Thailand) and the town of Pakse (Laos)." };
        public static Destination NamPhao = new Destination { Name = "NamPhao", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "" };
        public static Destination Pakse = new Destination { Name = "Pakse", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "" };
        public static Destination LuangNamtha = new Destination { Name = "Luang Namtha", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "" };
        public static Destination XiengKhouang = new Destination { Name = "Xieng Khouang", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "" };
        public static Destination Oudomsay = new Destination { Name = "Oudomsay", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "" };
        public static Destination NongNokKhiene = new Destination { Name = "Nong Nok Khiene", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "" };
        public static Destination MuangNgoiNeua = new Destination { Name = "Muang Ngoi Neua", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Muang Ngoi Neua is a small riverside village in Northern Laos wedged in between karst mountains at the confluence of the Nam Ngoi and the Nam Ou rivers. In the last few years it is beginning to appear as a destination on the Banana Pancake Trail as a backpacker favorite. Nevertheless, it remains a low-key destination in a stunning location. Interesting hikes can be made to tribal villages in the area." };

        public static List<Destination> GetAll()
        {
            List<Destination> destinations = new List<Destination>();
            destinations.Add(Namkan);
            destinations.Add(SopHun);
            destinations.Add(Vientiane);
            destinations.Add(Savannakhet);
            destinations.Add(LuangPrabang);
            destinations.Add(HuayXai);
            destinations.Add(Dansavanh);
            destinations.Add(PhouKeua);
            destinations.Add(NongKhiang);
            destinations.Add(ChongMek);
            destinations.Add(NamPhao);
            destinations.Add(Pakse);
            destinations.Add(LuangNamtha);
            destinations.Add(XiengKhouang);
            destinations.Add(Oudomsay);
            destinations.Add(NongNokKhiene);
            destinations.Add(MuangNgoiNeua);
            return destinations;
        }

    }
}
