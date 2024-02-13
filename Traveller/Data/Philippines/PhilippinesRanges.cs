using Domain.EntityFrameworkDictionary;
using Domain.Ranges;
using Data.EntityTypes;

namespace Data.Philippines
{
    /// <summary>
    /// In the archipelago there are three distinct seasons: the rainy season that runs from mid May to November, and two dry seasons, the cool and dry season which runs from December to February and the hot season running from March to May. The rains occur when the south-west monsoon blows (from mid May to November), while the north-east monsoon (December to May) is generally dry.
    /// </summary>
    public class PhilippinesRanges
    {
        //public static RangeChar SeasonRange = new RangeChar
        //{
        //    RangeType = RangeTypes.TourismSeasonRangeType,
        //    EntityKey_Description = new EntityFrameworkDictionary<char, string>()
        //    {
        //        Items = new List<DictionaryItem<char, string>>()
        //        {

        //            new DictionaryItem<char,string> { Key = 'A', Value = "Christmas and New Year are the most touristy and expensive times of the year."},
        //            new DictionaryItem<char,string> { Key = 'M', Value = "The north and the gulf coast are ideal in September and October."},
        //            new DictionaryItem<char,string> { Key = 'B', Value = "Visiting Kathmandu Valley during the monsoon is not advised as one may not be able to explore the attractions due to heavy rains and it is also dangerous to trek during this time of the year. The monsoon in Kathmandu ends around the month of September." }
        //        }
        //    },

        //    EntityKey_ByMonth = new EntityFrameworkDictionary<string, string>()
        //    {
        //        Items = new List<DictionaryItem<string, string>>()
        //        {
        //            new DictionaryItem<string,string> { Key = "January", Value ="X" },

        //            new DictionaryItem<string,string> { Key = "February", Value ="X" },

        //            new DictionaryItem<string,string> { Key = "March", Value ="X" },

        //            new DictionaryItem<string,string> { Key = "April", Value ="X" },

        //            new DictionaryItem<string,string> { Key = "May", Value ="X" },

        //            new DictionaryItem<string,string> { Key = "June", Value ="B" },

        //            new DictionaryItem<string,string> { Key = "July", Value ="B" },

        //            new DictionaryItem<string,string> { Key = "August", Value ="B" },

        //            new DictionaryItem<string,string> { Key = "September", Value ="M" },

        //            new DictionaryItem<string,string> { Key = "October", Value ="A" },

        //            new DictionaryItem<string,string> { Key = "November", Value ="A" },

        //            new DictionaryItem<string,string> { Key = "December", Value ="A" },
        //        }
        //    }
        //};

        public static RangeChar MonsoonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                    new DictionaryItem<char,string> { Key = 'M', Value = "In the archipelago there are three distinct seasons: the rainy season that runs from mid May to November, and two dry seasons, the cool and dry season which runs from December to February and the hot season running from March to May. The rains occur when the south-west monsoon blows (from mid May to November), while the north-east monsoon (December to May) is generally dry. In the archipelago there are three distinct seasons: the rainy season that runs from mid May to November, and two dry seasons, the cool and dry season which runs from December to February and the hot season running from March to May. The rains occur when the south-west monsoon blows (from mid May to November), while the north-east monsoon (December to May) is generally dry." },
                }
            },
            EntityDescription_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string,string> { Key = "January", Value ="Tag - Lamig. Between December and February. It is dry season but with less heat.Excellent for travel to the Philippines, as temperatures are cooler, without being too cold. Rainfall should be minimal in this month." },
                    new DictionaryItem<string,string> { Key = "February",  Value ="Tag - Lamig. Between December and February. It is dry season but with less heat.Very similar to January, but with slightly warmer temperatures. It is a very high season for Asian tourism."},
                    new DictionaryItem<string,string> { Key = "March",  Value ="Tag - Init. Between March and May. It is the hot and dry summer. Continues to be a good month for travel to the Philippines. During Holy Week there may be problems of availability of accommodations."},
                    new DictionaryItem<string,string> { Key = "April",   Value ="Tag - Init. Between March and May. It is the hot and dry summer. The highest temperatures within the dry season are reached, as this is the last month before the rains."}, 
                    new DictionaryItem<string,string> { Key = "May",  Value ="Tag - Init. Between March and May. It is the hot and dry summer. If you don't mind the heat it is a good time to travel, as the chances of rain are low and it is ideal for touring the mountainous areas."},
                    new DictionaryItem<string,string> { Key = "June",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonRains are noticeable in the north of the country, and will decrease southward as the month progresses. The Cebu area is still dry during this month."},     
                    new DictionaryItem<string,string> { Key = "July",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonRainfall is increasing and there is intermittent rainfall almost everywhere in the country, except around Cebu, which continues to have less rain."}, 
                    new DictionaryItem<string,string> { Key = "August",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonAugust is very similar to July in terms of rainfall, but it is the beginning of the typhoon season."},   
                    new DictionaryItem<string,string> { Key = "September",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonRains are heavy and the possibility of typhoons is higher, a factor to take into account when planning a trip."},  
                    new DictionaryItem<string,string> { Key = "October",   Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonThe rain is decreasing and by the end of the month it will have practically disappeared."},   
                    new DictionaryItem<string,string> { Key = "November",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Ulan. Between June and November. It is the wet seasonBeginning of the dry season although there is still a chance of typhoons, you will find mostly good weather."}, 
                    new DictionaryItem<string,string> { Key = "December",  Value ="Tropical storms hit the Philippines between June and December, the worst affected areas are the northern and eastern areas of the island of Luzon, the island of Bicol and Eastern Visayas (Samar, Leyte).Tag - Lamig. Between December and February. It is dry season but with less heat.This is a very pleasant time to travel, as temperatures are the coolest of the year and the probability of typhoons is already very low."},  }
            }
        };

        public static RangeChar MonsoonRangeEvaluator = new RangeChar
        {
            RangeType = RangeTypes.MonsoonEvaluatorRangeType,

            EntityEvaluator_ByMonth = new EntityFrameworkDictionary<int, int>()
            {
                Items = new List<DictionaryItem<int, int>>()
                {
                    new DictionaryItem<int,int> { Key = 1, Value = 1 },
                    new DictionaryItem<int,int> { Key = 2, Value = 1 },
                    new DictionaryItem<int,int> { Key = 3, Value = 1 },
                    new DictionaryItem<int,int> { Key = 4, Value = 1 },
                    new DictionaryItem<int,int> { Key = 5, Value = 1 },
                    new DictionaryItem<int,int> { Key = 6, Value = -1 },
                    new DictionaryItem<int,int> { Key = 7, Value = -1 },
                    new DictionaryItem<int,int> { Key = 8, Value = -1 },
                    new DictionaryItem<int,int> { Key = 9, Value = -1 },
                    new DictionaryItem<int,int> { Key = 10, Value = -1 },
                    new DictionaryItem<int,int> { Key = 11, Value = -1 },
                    new DictionaryItem<int,int> { Key = 12, Value = 1 },
                }
            }
        };
    }
}
