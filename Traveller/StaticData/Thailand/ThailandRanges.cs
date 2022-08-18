using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Thailand
{
    public class ThailandRanges
    {
        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Christmas and New Year are the most touristy and expensive times of the year."},
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "The north and the gulf coast are ideal in September and October."},
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Some islands are closed and, depending on the weather, fewer boats circulate; some leeway is recommended." }
                }

            }
            ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="M" },

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

                    new DictionaryItem<char> { DictionaryKey = 'S', DictionaryValue = "Rainy season or southwest monsoon (mid-May to mid-October). The monsoon prevails in southwestern Thailand although it rains throughout the country. Rainfall is even heavier from August to September. In southern Thailand the climate is a little different because the rains remain until the end of the year, which is the initial period of the northeast monsoon, with November being the wettest month." },
                    new DictionaryItem<char> { DictionaryKey = 'I', DictionaryValue = "Winter season or northeast monsoon (mid-October to mid-February). This is the mild period of the year with quite cold in December and January in the northern part of Thailand, but with heavy rainfall on the east coast of Thailand, especially from October to November."},
                    new DictionaryItem<char> { DictionaryKey = 'V', DictionaryValue = "Summer or pre-monsoon season (mid-February to mid-May). This is the transition period from the northeast to southwest monsoons. The weather becomes hotter, especially in upper Thailand. April is the warmest month." },

               }

            }
            ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="January is one of the best months of the year to travel to Thailand, with favorable weather conditions throughout the country. In fact it is one of the most popular months for tourists arriving from all over the world. Northern Thailand tends to be cool and dry and nighttime temperatures in the far north can be a bit chilly. In Bangkok the weather is warmer and drier, with temperatures hovering around 20-23°C throughout the month." },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="In much of northern Thailand such as Chiang Mai or Chiang Rai the weather is likely to be cool and dry, with little chance of rain. These favorable weather conditions make February an ideal month for outdoor activities up north and provide a break from the heat further south. In Bangkok the atmosphere is drier still and temperatures are warmer than in the north due to the lower altitude." },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="In March the temperature starts to rise throughout Thailand and it is especially noticeable in Chiang Mai and the rest of the north of the country where the coolness disappears and gives way to summer. During this month the temperature can reach 35°C during the day and there is little chance of rain." },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="Unless you love the heat, avoid Thailand in April. This is the hottest month of the year in the entire country, and the weather is sweltering, especially for travelers who are not well acclimated to these temperatures. The intense heat and humidity in Thailand with the monsoon approaching is exhausting, so if you have no choice but to come in April, look for air-conditioned accommodation..." },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="Much awaited by locals, the month of May brings the monsoon and the oppressive heat of the previous month dissipates. Although for tourists it is not so pleasant, do not despair because the rainy season in Thailand is not synonymous with gray days but heavy rains that last for a while and in a few minutes give way to the sun again." },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="June is very wet and the southwest monsoon moves into the center of the country. Temperatures drop slightly due to thunderstorms during the afternoons and evenings and the sun shines most of the time when it is not raining. On the positive side, the water transforms the landscape and makes the countryside green and the rivers flowing. Watch out for flash floods and leeches." },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="July is a month of heavy rains, although the sun is out and the heat is back. The Andaman coast is especially humid, but you'll still have a chance to come back from the trip with a tan. This is the best time to see the waterfalls in all their splendor. Watch out for landslides and flash floods. The sea can be rough on the west coast of Thailand." },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="Rainfall is at its heaviest in August, with northeastern Thailand experiencing the most pronounced rainfall. Some places such as Bangkok and Trat province experience flooding throughout the month." },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="The gulf coast islands, such as Koh Samui, Koh Phangan and Koh Tao, are the best destinations for a Thailand vacation in September, being drier and cooler than the rest of the country. Although this does not mean that these islands are completely spared from the monsoon. Central Thailand and Bangkok suffer the worst rains during September, and the Andaman coast is extremely wet with rough seas." },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="It still rains in Thailand's islands and southern coastal regions in October, but the monsoon begins to withdraw from the central, northern and northeastern areas of the country. In Bangkok and central Thailand, October still brings some rainfall, but its frequency, duration and volume decreases dramatically, particularly in the second half of the month, when the wind begins to change direction. Similarly, the rain retreats from the north, which enjoys moderate temperatures. It is a pleasant time to spend a vacation in this area, especially for hiking." },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="By November, the rain has virtually disappeared from much of Thailand, especially at the end of the month. Humidity disappears and temperatures remain relatively low (by Thai standards). November is a good time of year to visit Chiang Mai, Chiang Rai and northern Thailand, the region enjoys sunny, predominantly dry days and pleasant temperatures conducive to outdoor activities, although be aware that nighttime temperatures in the north can be a bit chilly." },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="December is one of the best months of the year to travel to Thailand: virtually no rain, pleasant temperatures and plenty of sunshine without being sweltering. Low humidity levels and an average temperature of 26°C in central Thailand and Bangkok are ideal for tourism. The north of the country also enjoys favorable climatic conditions for hiking in the Golden Triangle region and through the Chiang Mai countryside, with slightly cooler temperatures than in Bangkok (average temperature: 23-25°C)." },

                }

            }

        };
    }
}
