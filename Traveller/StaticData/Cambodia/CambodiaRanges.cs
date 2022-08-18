using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Cambodia
{
    public class CambodiaRanges
    {
        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Cooler and windier, with almost Mediterranean temperatures. It is best to book accommodation in advance for Christmas and New Year's Eve." },

                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "In April and May, the thermometer reaches 40°C (104°F). October and November are great for travel: it rains less but the dry season has not yet started." },

                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Discounts on accommodations and clouds make it a good time to visit the temples. The south coast can be crowded with western tourists." },

                }

            }
           ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="A" },

                }

            }

        };

        public static RangeChar MonsoonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {
                    //https://www.adventure-life.com/vietnam/articles/when-is-the-best-time-to-visit-vietnam
                    new DictionaryItem<char> { DictionaryKey = 'W', DictionaryValue = "Cambodia's dry season lasts from October to April, when the dry north-east monsoon arrives, characterised by hot wind blowing across the entire country. Whilst November to January are quite cool (high 20°C's), by April the weather is scorching making early morning and late afternoon Angkor Temple tours, with a few hours by the hotel pool at lunchtime, the preference for many. Thanks to the hot weather this is unsurprisingly the season when Cambodia's tourist numbers peak. In more remote parts, such as the north east regions of Mondulkiri & Ratanakiri, the roads are at their best and journey times are shorter because of this. Kep and Sihanoukville on the south coast are popular during this season as they bask in the brilliant sunshine and sea conditions are very favourable."},
                    new DictionaryItem<char> { DictionaryKey = 'S', DictionaryValue = "Cambodia's wet season comes courtesy of the southwest monsoon and lasts from May to October, bringing with it almost 75% of Cambodia's annual rainfall. Across Cambodia, throughout much of the rainy season, daytime temperatures average between 25°C and 27°C. The early months of the wet season (May – July) remain very hot with infrequent rainfall usually in the form of short downpours. In the latter months (late July – September) the rain tends to becomes more constant and is heavy at times, especially in coastal and rural regions. Travel in the more remote corners of the country, such as Mondulkiri & Ratanakiri, is almost impossible due to the state of the roads and journeys into the north east are inadvisable during the peak wet season because of this. There is also very limited access to Bamboo Island (near Kep) due to high seas."},
               }

            }
         ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {
                //https://www.roughguides.com/vietnam/when-to-go/
                Dictionary = new List<DictionaryItem<string>>()
                {
                    // new DictionaryItem<string> { DictionaryKey = "January",   DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "February",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "March",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "April",   DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "May",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "June",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "July",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "August",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "September",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "November",  DictionaryValue ="" },
                    //new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="" }, }

                    new DictionaryItem<string> { DictionaryKey = "January",   DictionaryValue ="First period of the dry season is the least hot of the year." },
                    new DictionaryItem<string> { DictionaryKey = "February",  DictionaryValue ="Second period of dry season, from mid-February to May, before the monsoon arrives, is the hottest of the year" }, 
                    new DictionaryItem<string> { DictionaryKey = "March",  DictionaryValue ="Second period of dry season, from mid-February to May, before the monsoon arrives, is the hottest of the year" },
                    new DictionaryItem<string> { DictionaryKey = "April",   DictionaryValue ="Second period of dry season. Hottest months are April and May. The heat becomes oppressive;" }, 
                    new DictionaryItem<string> { DictionaryKey = "May",  DictionaryValue ="Second period of dry season. Hottest months are April and May. The heat becomes oppressive; Rainy season from May to mid-November due to the south-west monsoon" },  
                    new DictionaryItem<string> { DictionaryKey = "June",  DictionaryValue ="Rainy season from May to mid-November due to the south-west monsoon. In the rainy season, the temperature is a bit lower, but the humidity is higher, so the weather is hot and muggy." },   
                    new DictionaryItem<string> { DictionaryKey = "July",  DictionaryValue ="Rainy season from May to mid-November due to the south-west monsoon. In the rainy season, the temperature is a bit lower, but the humidity is higher, so the weather is hot and muggy." },  
                    new DictionaryItem<string> { DictionaryKey = "August",  DictionaryValue ="Rainy season from May to mid-November due to the south-west monsoon. In the rainy season, the temperature is a bit lower, but the humidity is higher, so the weather is hot and muggy." },
                    new DictionaryItem<string> { DictionaryKey = "September",  DictionaryValue ="Rainy season from May to mid-November due to the south-west monsoon. In the rainy season, the temperature is a bit lower, but the humidity is higher, so the weather is hot and muggy." },   
                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="Rainy season from May to mid-November due to the south-west monsoon" }, 
                    new DictionaryItem<string> { DictionaryKey = "November",  DictionaryValue ="Rainy season ends in mid-November. The monsoon withdraws in early November in the north and between the middle and the end of the month in the center-south." },
                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="First period of the dry season is the least hot of the year. Coolest month" }, }

            }

        };
    }
}
