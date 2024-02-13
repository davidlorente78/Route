using Data.Cambodia;
using Data.EntityTypes;
using System.Reflection;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        public static Destination Bavet = new Destination { CountryId = 5, Name = "Bavet", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination PrekChak = new Destination { CountryId = 5, Name = "Prek Chak", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };

        public static Destination KaanSamnor = new Destination { CountryId = 5, Name = "Kaan Samnor", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination KamSamnar = new Destination { CountryId = 5, Name = "K'am Samnar", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination Prom = new Destination { CountryId = 5, Name = "Prom", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination ChamYeam = new Destination { CountryId = 5, Name = "Cham Yeam", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination TropaengKreal = new Destination { CountryId = 5, Name = "Tropaeng Kreal", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };


        public static Destination Poipet = new Destination
        {
            CountryId = 5,
            Name = "Poipet",
            Description = "Poipet is a city located in the northwest of Cambodia, near the border with Thailand. It is a major border crossing between the two countries and is known for its casinos and gambling industry. In recent years, Poipet has also become a popular destination for Thai tourists seeking a quick getaway, as it offers a range of entertainment options and accommodations. Despite its reputation as a bustling border town, Poipet is also home to several important historical and cultural sites, such as the ancient temple ruins of Banteay Chhmar and Prasat Preah Vihear.",
            LocalName = "ប៉ោយប៉ែត",
            DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing }
        };

        public static Destination Angkor = new Destination { CountryId = 5, Name = "Angkor", Picture = "Angkor.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };

        public static Destination Battambang = new Destination
        {
            CountryId = 5,
            Description = "Battambang is a city in northwestern Cambodia, located on the Sangkae River. It is the second-largest city in the country, after Phnom Penh. Battambang has a rich history and is known for its well-preserved colonial architecture, traditional art, and natural beauty. It is a popular destination for tourists who want to explore the countryside, visit ancient temples, and experience local Cambodian culture. Some of the notable attractions in Battambang include the Phare Ponleu Selpak circus, the bamboo train, and the Wat Banan temple.",
            Name = "Battambang",
            Picture = "Battambang.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination SiemReap = new Destination
        {
            CountryId = 5,
            Name = "Siem Reap",
            Description = "Siem Reap is a province located in northwestern Cambodia and is a popular tourist destination. The town of Siem Reap is the gateway to the famous Angkor Wat temple complex, which is a UNESCO World Heritage site and one of the largest religious monuments in the world. Siem Reap is also home to many other temples, including Bayon, Ta Prohm, and Banteay Srei. In addition to its historical sites, Siem Reap has many other attractions, such as a vibrant nightlife, markets, art galleries, and museums. The town is also known for its traditional Apsara dance performances and Khmer cuisine, which features a mix of sweet, sour, salty, and bitter flavors. Siem Reap is a must-visit destination for anyone interested in history, culture, and architecture.",
            Picture = "SiemReap.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }
        };

        public static Destination PhnomPenh = new Destination
        {
            CountryId = 5,
            Name = "Phnom Penh",
            Description = "Phnom Penh is the capital and largest city of Cambodia, located in the south-central part of the country. It has a rich history and culture, with a mix of Khmer, French, and Chinese influences. Popular attractions in Phnom Penh include the Royal Palace, the National Museum of Cambodia, the Tuol Sleng Genocide Museum, and the Choeung Ek Genocidal Center. The city is also known for its vibrant food scene, including street food stalls and upscale restaurants serving traditional Khmer dishes as well as international cuisine. Phnom Penh is a popular tourist destination and is also an important economic and cultural center for Cambodia.",
            Picture = "PhnomPenh.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }
        };

        public static Destination Sihanoukville = new Destination
        {
            CountryId = 5,
            Description = "Sihanoukville is a coastal city in southwestern Cambodia, known for its beautiful beaches and stunning views of the Gulf of Thailand. It is a popular tourist destination, with a range of activities available, including swimming, sunbathing, boating, snorkeling, and scuba diving. In addition to its natural beauty, Sihanoukville is also home to a variety of restaurants, bars, and nightclubs, offering visitors a vibrant nightlife scene. The city is also a hub for transportation, with a major port and an international airport connecting it to other destinations in Cambodia and beyond.",
            Name = "Sihanoukville",
            Picture = "Sihanoukville.jpg",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }
        };

        public static List<Destination> GetAll()
        {
            var fields = typeof(CambodiaDestinations).GetFields(BindingFlags.Static | BindingFlags.Public);

            
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

        //public static List<Destination> GetAll()
        //{

        //    List<Destination> destinations = new List<Destination>
        //    {
        //        Bavet,
        //        PrekChak,
        //        KaanSamnor,
        //        Poipet,
        //        Angkor,
        //        Battambang,
        //        SiemReap,
        //        PhnomPenh,
        //        Sihanoukville,
        //        KamSamnar,
        //        Prom,
        //        ChamYeam,
        //        TropaengKreal
        //    };        

        //    return destinations;
        //}
    }
}