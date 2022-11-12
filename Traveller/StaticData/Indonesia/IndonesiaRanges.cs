using Domain.EntityFrameworkDictionary;
using Domain.Ranges;
using StaticData.EntityTypes;

namespace StaticData.Indonesia
{
    public class IndonesiaRanges
    {

        private static List<char> SeasonDefinition = new List<char> { 'B', 'B', 'B', 'M', 'M', 'A', 'A', 'A', 'M', 'M', 'B', 'B', };

        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char,string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                      new DictionaryItem<char,string> { Key = 'A', Value = "If you don't mind heavy traffic and sharing crowded beaches, go when the weather is best. July and August are often the driest months with pleasant temperatures."},
                      new DictionaryItem<char,string> { Key = 'M', Value = "A good compromise is to risk occasional rain showers in exchange for more peace. The shoulder months before and after the high season (particularly April, May, and September) are enjoyable and experience many sunny days."},
                      new DictionaryItem<char,string> { Key = 'B', Value = "The wettest months to visit Bali are from November to March. December, January, and February are extra rainy and a little hotter. These are the peak months in Thailand and countries north of Indonesia that are celebrating their dry seasons before the heat really moves in." }

                  }
            }
          ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string,string>()
            {

                Items = new List<DictionaryItem<string, string>>()
                {

                    new DictionaryItem<string,string> { Key = "January", Value = SeasonDefinition.ElementAt(0).ToString() },

                    new DictionaryItem<string,string> { Key = "February", Value= SeasonDefinition.ElementAt(1).ToString() },

                    new DictionaryItem<string,string> { Key = "March", Value = SeasonDefinition.ElementAt(2).ToString() },

                    new DictionaryItem<string,string> { Key = "April", Value = SeasonDefinition.ElementAt(3).ToString() },

                    new DictionaryItem<string,string> { Key = "May", Value = SeasonDefinition.ElementAt(4).ToString() },

                    new DictionaryItem<string,string> { Key = "June", Value = SeasonDefinition.ElementAt(5).ToString() },

                    new DictionaryItem<string,string> { Key = "July", Value = SeasonDefinition.ElementAt(6).ToString() },

                    new DictionaryItem<string,string> { Key = "August", Value = SeasonDefinition.ElementAt(7).ToString() },

                    new DictionaryItem<string,string> { Key = "September",Value = SeasonDefinition.ElementAt(8).ToString() },

                    new DictionaryItem<string,string> { Key = "October", Value = SeasonDefinition.ElementAt(9).ToString() },

                    new DictionaryItem<string,string> { Key = "November", Value = SeasonDefinition.ElementAt(10).ToString() },

                    new DictionaryItem<string,string> { Key = "December",Value = SeasonDefinition.ElementAt(11).ToString() },

                }

            }

        };

        public static RangeChar MonsoonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char,string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {

                    new DictionaryItem<char,string> { Key = 'W', Value = "Bali has a tropical climate, hot all year round, with a rainy season from November to March, due to the northwest monsoon, and a relatively dry season from April to October, when, however, some showers can still occur. In the rainy season, it usually rains a couple of hours in the morning and a couple of hours in the afternoon, while in the rest of the day the sun shines for a few hours.Mosquitoes are much worse between rains, making dengue fever more of a threat on the island. Visibility at dive and snorkel sites is often worse because of sediment washed into the sea. Rougher seas may make boat trips less enjoyable." },
                   
                }
            }
           ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string, string>()
            {

                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string,string> { Key = "January",Value ="Rainy season. In the rainy season the sun shines for a few hours a day, between one rain shower and another. There's muggy heat due to high humidity. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },

                    new DictionaryItem<string,string> { Key = "February", Value ="Rainy season. In the rainy season the sun shines for a few hours a day, between one rain shower and another. There's muggy heat due to high humidity.Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },

                    new DictionaryItem<string,string> { Key = "March", Value ="Rainy season. In the rainy season the sun shines for a few hours a day, between one rain shower and another. There's muggy heat due to high humidity. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },

                    new DictionaryItem<string,string> { Key = "April", Value ="Dry season. In Bali, there's plenty of sunshine in the dry season. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },  
                    
                    new DictionaryItem<string,string> { Key = "May", Value ="May and October, too, are months you may want to consider, in fact they are the best ones among those that do not fall in the high season: they are a bit more muggy and rainy, but they are still out of the actual rainy season. However, in inland and mountainous areas, thunderstorms are frequent. Dry season. In Bali, there's plenty of sunshine in the dry season. " },

                    new DictionaryItem<string,string> { Key = "June",Value ="The best time to travel to Bali and enjoy its beaches is from June to September, the weather is usually sunny, the heat is not too intense, and in any case, it's tempered by the breeze. There are just some brief downpours or thunderstorms every now and then, which, however, are more likely at night and in the early morning.  Dry season. Temperatures are a bit lower from June to September, when the southeast monsoon blows, which brings a bit of cooler air, and the average drops to about 26.5/27 °C (79.5/80.5 °F)." },

                    new DictionaryItem<string,string> { Key = "July", Value ="The best time to travel to Bali and enjoy its beaches is from June to September, the weather is usually sunny, the heat is not too intense, and in any case, it's tempered by the breeze. There are just some brief downpours or thunderstorms every now and then, which, however, are more likely at night and in the early morning.  Dry season. In Bali, there's plenty of sunshine in the dry season. Temperatures  are a bit lower from June to September, when the southeast monsoon blows, which brings a bit of cooler air, and the average drops to about 26.5/27 °C (79.5/80.5 °F)." },

                    new DictionaryItem<string,string> { Key = "August", Value ="August is the best month, since it is the driest. The best time to travel to Bali and enjoy its beaches is from June to September, the weather is usually sunny, the heat is not too intense, and in any case, it's tempered by the breeze. There are just some brief downpours or thunderstorms every now and then, which, however, are more likely at night and in the early morning.  Dry season. In Bali, there's plenty of sunshine in the dry season. Temperatures  are a bit lower from June to September, when the southeast monsoon blows, which brings a bit of cooler air, and the average drops to about 26.5/27 °C (79.5/80.5 °F)." },

                    new DictionaryItem<string,string> { Key = "September", Value ="The best time to travel to Bali and enjoy its beaches is from June to September, the weather is usually sunny, the heat is not too intense, and in any case, it's tempered by the breeze. There are just some brief downpours or thunderstorms every now and then, which, however, are more likely at night and in the early morning.  Dry season. In Bali, there's plenty of sunshine in the dry season. Temperatures  are a bit lower from June to September, when the southeast monsoon blows, which brings a bit of cooler air, and the average drops to about 26.5/27 °C (79.5/80.5 °F)." },

                    new DictionaryItem<string,string> { Key = "October",Value = "May and October, too, are months you may want to consider, in fact they are the best ones among those that do not fall in the high season: they are a bit more muggy and rainy, but they are still out of the actual rainy season. However, in inland and mountainous areas, thunderstorms are frequent. Rainy season. In the rainy season the sun shines for a few hours a day, between one rain shower and another. There's muggy heat due to high humidity. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },   
                    
                    new DictionaryItem<string,string> { Key = "November", Value ="Rainy season. In the rainy season the sun shines for a few hours a day, between one rain shower and another. There's muggy heat due to high humidity. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" },

                    new DictionaryItem<string,string> { Key = "December", Value ="Rainy season.  In the rainy season the sun shines for a few hours a day, between one rain shower and another.There's muggy heat due to high humidity. Temperatures are high and uniform throughout the year. They are slightly higher from October to April, when the daily average is around 28 °C (82 °F)" }
                }

            }

        };

        public static RangeChar MonsoonRangeEvaluator = new RangeChar
        {
            RangeType = RangeTypes.MonsoonEvaluatorRangeType,

            EntityEvaluator_ByMonth = new EntityFrameworkDictionary<int, int>()
            {

                Items = new List<DictionaryItem<int, int>>()
                {
                    new DictionaryItem<int,int> { Key = 1, Value =-1 },
                    new DictionaryItem<int,int> { Key = 2, Value =-1 },
                    new DictionaryItem<int,int> { Key = 3, Value =-1 },
                    new DictionaryItem<int,int> { Key = 4, Value =0 },
                    new DictionaryItem<int,int> { Key = 5, Value =1 },
                    new DictionaryItem<int,int> { Key = 6, Value =1 },
                    new DictionaryItem<int,int> { Key = 7, Value =1 },
                    new DictionaryItem<int,int> { Key = 8, Value  = 1 },
                    new DictionaryItem<int,int> { Key = 9, Value = 1 },
                    new DictionaryItem<int,int> { Key = 10, Value = 0 },
                    new DictionaryItem<int,int> { Key = 11, Value = -1 },
                    new DictionaryItem<int,int> { Key = 12, Value = -1 },
                }

            }

        };
    }
}
