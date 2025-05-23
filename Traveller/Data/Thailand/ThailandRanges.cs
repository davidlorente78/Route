﻿using Domain.EntityFrameworkDictionary;
using Domain.Ranges;
using Data.EntityTypes;

namespace Data.Thailand
{
    public class ThailandRanges
    {
        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                    new DictionaryItem<char,string> { Key = 'A', Value = "Christmas and New Year are the most touristy and expensive times of the year."},
                    new DictionaryItem<char,string> { Key = 'M', Value = "The north and the gulf coast are ideal in September and October."},
                    new DictionaryItem<char,string> { Key = 'B', Value = "Some islands are closed and, depending on the weather, fewer boats circulate; some leeway is recommended." }
                }
            },

            EntityKey_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string, string> { Key = "January", Value ="A" },

                    new DictionaryItem<string, string> { Key = "February", Value ="A" },

                    new DictionaryItem<string, string> { Key = "March", Value ="A" },

                    new DictionaryItem<string, string> { Key = "April", Value ="M" },

                    new DictionaryItem<string, string> { Key = "May", Value ="M" },

                    new DictionaryItem<string, string> { Key = "June", Value ="M" },

                    new DictionaryItem<string, string> { Key = "July", Value ="B" },

                    new DictionaryItem<string, string> { Key = "August", Value ="B" },

                    new DictionaryItem<string, string> { Key = "September", Value ="M" },

                    new DictionaryItem<string, string> { Key = "October", Value ="M" },

                    new DictionaryItem<string, string> { Key = "November", Value ="A" },

                    new DictionaryItem<string, string> { Key = "December", Value ="A" },
                }
            }
        };

        public static RangeChar MonsoonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                    new DictionaryItem<char,string> { Key = 'S', Value = "Rainy season or southwest monsoon (mid-May to mid-October). The monsoon prevails in southwestern Thailand although it rains throughout the country. Rainfall is even heavier from August to September. In southern Thailand the climate is a little different because the rains remain until the end of the year, which is the initial period of the northeast monsoon, with November being the wettest month." },
                    new DictionaryItem<char,string> { Key = 'I', Value = "Winter season or northeast monsoon (mid-October to mid-February). This is the mild period of the year with quite cold in December and January in the northern part of Thailand, but with heavy rainfall on the east coast of Thailand, especially from October to November."},
                    new DictionaryItem<char,string> { Key = 'V', Value = "Summer or pre-monsoon season (mid-February to mid-May). This is the transition period from the northeast to southwest monsoons. The weather becomes hotter, especially in upper Thailand. April is the warmest month." },
               }
            },

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string,string> { Key = "January", Value ="January is one of the best months of the year to travel to Thailand, with favorable weather conditions throughout the country. In fact it is one of the most popular months for tourists arriving from all over the world. Northern Thailand tends to be cool and dry and nighttime temperatures in the far north can be a bit chilly. In Bangkok the weather is warmer and drier, with temperatures hovering around 20-23°C throughout the month." },

                    new DictionaryItem<string,string> { Key = "February", Value ="February. In much of northern Thailand such as Chiang Mai or Chiang Rai the weather is likely to be cool and dry, with little chance of rain. These favorable weather conditions make February an ideal month for outdoor activities up north and provide a break from the heat further south. In Bangkok the atmosphere is drier still and temperatures are warmer than in the north due to the lower altitude." },

                    new DictionaryItem<string,string> { Key = "March", Value ="In March the temperature starts to rise throughout Thailand and it is especially noticeable in Chiang Mai and the rest of the north of the country where the coolness disappears and gives way to summer. During this month the temperature can reach 35°C during the day and there is little chance of rain." },

                    new DictionaryItem<string,string> { Key = "April", Value ="Unless you love the heat, avoid Thailand in April. This is the hottest month of the year in the entire country, and the weather is sweltering, especially for travelers who are not well acclimated to these temperatures. The intense heat and humidity in Thailand with the monsoon approaching is exhausting, so if you have no choice but to come in April, look for air-conditioned accommodation..." },

                    new DictionaryItem<string,string> { Key = "May", Value ="May. Much awaited by locals, the month of May brings the monsoon and the oppressive heat of the previous month dissipates. Although for tourists it is not so pleasant, do not despair because the rainy season in Thailand is not synonymous with gray days but heavy rains that last for a while and in a few minutes give way to the sun again." },

                    new DictionaryItem<string,string> { Key = "June", Value ="June is very wet and the southwest monsoon moves into the center of the country. Temperatures drop slightly due to thunderstorms during the afternoons and evenings and the sun shines most of the time when it is not raining. On the positive side, the water transforms the landscape and makes the countryside green and the rivers flowing. Watch out for flash floods and leeches." },

                    new DictionaryItem<string,string> { Key = "July", Value ="July is a month of heavy rains, although the sun is out and the heat is back. The Andaman coast is especially humid, but you'll still have a chance to come back from the trip with a tan. This is the best time to see the waterfalls in all their splendor. Watch out for landslides and flash floods. The sea can be rough on the west coast of Thailand." },

                    new DictionaryItem<string,string> { Key = "August", Value ="Rainfall is at its heaviest in August, with northeastern Thailand experiencing the most pronounced rainfall. Some places such as Bangkok and Trat province experience flooding throughout the month." },

                    new DictionaryItem<string,string> { Key = "September", Value ="September. The gulf coast islands, such as Koh Samui, Koh Phangan and Koh Tao, are the best destinations for a Thailand vacation in September, being drier and cooler than the rest of the country. Although this does not mean that these islands are completely spared from the monsoon. Central Thailand and Bangkok suffer the worst rains during September, and the Andaman coast is extremely wet with rough seas." },

                    new DictionaryItem<string,string> { Key = "October", Value ="October. It still rains in Thailand's islands and southern coastal regions in October, but the monsoon begins to withdraw from the central, northern and northeastern areas of the country. In Bangkok and central Thailand, October still brings some rainfall, but its frequency, duration and volume decreases dramatically, particularly in the second half of the month, when the wind begins to change direction. Similarly, the rain retreats from the north, which enjoys moderate temperatures. It is a pleasant time to spend a vacation in this area, especially for hiking." },

                    new DictionaryItem<string,string> { Key = "November", Value ="By November, the rain has virtually disappeared from much of Thailand, especially at the end of the month. Humidity disappears and temperatures remain relatively low (by Thai standards). November is a good time of year to visit Chiang Mai, Chiang Rai and northern Thailand, the region enjoys sunny, predominantly dry days and pleasant temperatures conducive to outdoor activities, although be aware that nighttime temperatures in the north can be a bit chilly." },

                    new DictionaryItem<string,string> { Key = "December", Value ="December is one of the best months of the year to travel to Thailand: virtually no rain, pleasant temperatures and plenty of sunshine without being sweltering. Low humidity levels and an average temperature of 26°C in central Thailand and Bangkok are ideal for tourism. The north of the country also enjoys favorable climatic conditions for hiking in the Golden Triangle region and through the Chiang Mai countryside, with slightly cooler temperatures than in Bangkok (average temperature: 23-25°C)." },
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
                    new DictionaryItem<int,int> { Key = 1, Value =1 },
                    new DictionaryItem<int,int> { Key = 2, Value =1 },
                    new DictionaryItem<int,int> { Key = 3, Value =0 },
                    new DictionaryItem<int,int> { Key = 4, Value =-1 },
                    new DictionaryItem<int,int> { Key = 5, Value =0 },
                    new DictionaryItem<int,int> { Key = 6, Value =0 },
                    new DictionaryItem<int,int> { Key = 7, Value =-1 },
                    new DictionaryItem<int,int> { Key = 8, Value  = -1 },
                    new DictionaryItem<int,int> { Key = 9, Value = 0 },
                    new DictionaryItem<int,int> { Key = 10, Value = 1 },
                    new DictionaryItem<int,int> { Key = 11, Value =1 },
                    new DictionaryItem<int,int> { Key = 12, Value =1 },
                }
            }
        };

        public static ICollection<RangeChar> GetAll() => new List<RangeChar> { SeasonRange, MonsoonRange, MonsoonRangeEvaluator };
    }
}
