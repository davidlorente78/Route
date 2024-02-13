using Data.EntityTypes;
using System.Reflection;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosDestinations
    {
        public static Destination Namkan = new Destination { Name = "Namkan", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Land crossing used when arriving in Laos from Hanoi to Luang Prabang" };
        public static Destination SopHun = new Destination { Name = "Tay Trang - Sop hun ", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Land crossing used when arriving in Laos from Hanoi to Vientiane" };
        public static Destination Vientiane = new Destination { CountryId = 1, Name = "Vientiane", Picture = "/Vientiane.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing, DestinationTypes.Airport, DestinationTypes.Tourism }, Description = "Vientiane" };
        public static Destination Savannakhet = new Destination { Name = "Savannakhet", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }, Description = "Savannakhet" };
        public static Destination LuangPrabang = new Destination { CountryId = 1, Name = "Luang Prabang", Picture = "/LuangPrabang.png", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }, Description = "Luang Prabang" };
        public static Destination HuayXai = new Destination { CountryId = 1, Name = "Huay Xai", Picture = "/HuayXai.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing, DestinationTypes.Airport, DestinationTypes.Tourism }, Description = "Here begins the downstream crossing of the Mekong to Luang Prabang." };
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
        public static Destination MuangNgoiNeua = new Destination { Name = "Muang Ngoi Neua", Picture = "/MuangNgoiNeua.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Muang Ngoi Neua is a small riverside village in Northern Laos wedged in between karst mountains at the confluence of the Nam Ngoi and the Nam Ou rivers. In the last few years it is beginning to appear as a destination on the Banana Pancake Trail as a backpacker favorite. Nevertheless, it remains a low-key destination in a stunning location. Interesting hikes can be made to tribal villages in the area." };

        public static Destination VangVieng = new Destination
        {
            Name = "Vang Vieng",
            Picture = "/VangVieng.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism },
            Description = "Vang Vieng is a town surrounded by limestone karst hills and caves. The Nam Song River flows through the town, offering opportunities for activities such as tubing and kayaking. The picturesque landscape, caves, and outdoor adventures make Vang Vieng a popular destination for nature enthusiasts and adventure seekers."
        };

        public static Destination Thakhek = new Destination
        {
            Name = "Thakhek",
            Picture = "/Thakhek.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism },
            Description = "Thakhek is a town along the Mekong River known for its French colonial architecture and as a gateway to the famous Kong Lor Cave. Visitors to Thakhek can explore the scenic surroundings, visit historical sites, and embark on cave adventures, making it a charming destination in central Laos."
        };

        public static Destination DonDet = new Destination
        {
            Name = "Don Det",
            Picture = "/DonDet.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism },
            Description = "Don Det is one of the 4,000 Islands in the Mekong River and part of the Si Phan Don archipelago. Known for its relaxed atmosphere and stunning river views, Don Det is a popular destination for backpackers and those seeking a tranquil escape. Visitors can enjoy sunsets over the Mekong, explore waterfalls, and relax in hammocks by the river."
        };

        public static Destination Champasak = new Destination
        {
            Name = "Champasak",
            Picture = "/Champasak.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism },
            Description = "Champasak is a province in southern Laos with a rich cultural and historical heritage. The UNESCO-listed Wat Phu temple complex, ancient ruins, and serene landscapes make Champasak an intriguing destination for history enthusiasts and nature lovers alike."
        };
        public static List<Destination> GetAll()
        {
            var fields = typeof(LaosDestinations).GetFields(BindingFlags.Static | BindingFlags.Public);

            var destinations = new List<Destination>();

            foreach (var field in fields)
            {
                if (field.FieldType == typeof(Destination))
                {
                    destinations.Add((Destination)field.GetValue(null)!);
                }
            }

            return destinations;
        }
    }
}
