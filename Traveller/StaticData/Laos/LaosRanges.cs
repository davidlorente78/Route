using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Laos
{
    public class LaosRanges
    {

        private static List<char> SeasonDefinition = new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'M', 'M', 'B', 'B', 'A', 'A', };

        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                      new DictionaryItem<char,string> { Key = 'A', Value = "Prices increase up to 50% on the coast; it is recommended to book hotels in advance."},
                      new DictionaryItem<char,string> { Key = 'M', Value = "The green landscapes are beautiful. Preferred season for Spanish travelers, as well as backpackers from all over the world."},
                      new DictionaryItem<char,string> { Key = 'B', Value = "April and May are hot, with temperatures reaching 40ºC. In September and October it can rain quite a lot, although the deluges are accompanied by incredible cloud formations." }

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
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {

                    new DictionaryItem<char,string> { Key = 'W', Value = "The wet season in Laos runs from around May to October, and as with many Southeast Asian countries, the monsoon is characterised by a downpour for a few hours each day, rather than all-day torrential downpours. While the rainy season tends to strike Laos pretty much uniformally, there are a couple of regional oddities. Laos' wet season tends to hit Phongsali a little early due to it catching a bit of rain from southern China, while Hua Phan and Xieng Khuang tend to get a little early rain from Vietnam. Generally speaking, the higher you are, the more rain you get, and the towns along the Mekong River south of Vientiane get the least rain. As with Cambodia, the most obvious effect of the wet season is damaged infrastructure. Landslides are common, as are severely rutted roads. While the road network is generally far better (that is, sealed) than Cambodia's, the topography of Laos (pretty mountainous) lends itself to landslides, some minor, some not-so-minor. Also, with all this rainfall, the rivers can become beastly and delays due to bridges being down are not uncommon. Don't be surprised if your trip takes longer than expected. All in all, land transport during Laos' wet season can be slow and soggy. On the upside, boat transport comes into its own during the great wet. Rivers are high so the slowboats can make better pace. Along the Mekong River many of the rapids are submerged, helping the slowboats with their deeper drafts, but if you're considering a speedboat trip, be warned that the heavy rainfall brings a lot of refuse into the river, and hitting a submerged log at 50km/h can be very messy. This is yet another reason not to get on a speedboat. Other advantages of this season are lower temperatures, cleaner air and smaller crowds." },
                    new DictionaryItem<char,string> { Key = 'I', Value = "Laos' dry season has two distinct sub-sections -- first comes the cool dry season and then comes the hot dry season -- the former is one of the most popular times to visit Laos, the later less so. The cool dry season runs from November to February and the hot dry season from March to April. What the hot season lacks in length it makes up for in ferocity – it's hot, damn hot. What makes the hot season even more unbearable is the smoke factor -- from March to May farmers set fire to rice stubble and degraded (and not-so-degraded) forest to improve soil fertility in preparation for a new rice crop. The resulting fires cover most of Laos (including Luang Prabang) in a layer of smoke which, aside from ruining views and photos, can become really irritating to the eyes. March to May in Laos -- yuck! The cool, dry season on the other hand is an excellent time to go. Temperatures are relatively low, the air is cleaner and, particularly in November and December, the rivers are high enough to make river travel a breeze. Not surprisingly, this period in Laos is the peak season for travellers. "}
                }
            }
           ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                ///https://www.selectiveasia.com/weather/january
                Items = new List<DictionaryItem<string, string>>()
                {

                    new DictionaryItem<string,string> { Key = "January",Value ="Cool dry season. December and January are part of dry and cool season. Central regions are having nice warm weather. Temperature range is between 22 and 25 °C (72-75 °F). Mountainous areas are naturally cooler with 15 to 21 °C (59-70 °F) depending on altitude of certain location with occasional rains. The dry season continues during the month of January, promising premium travelling conditions throughout Laos. Comfortable average temperatures, plenty of sunshine, and minimal rainfall can be expected across the country. " },

                    new DictionaryItem<string,string> { Key = "February", Value ="Cool dry season. Entrying Hoy dry season. Technically February relates to hot season but first half of the month is rather comfortable for active vacation in the country. In addition amount of visitors’ decreases as well as pricing. February’s weather conditions are similar to January as dry season continues in Laos. Sunny days, comfortable temperatures and low rainfall can be expected throughout the country. It's an excellent time of year if you plan on trekking in Phongsali and the northern regions." },

                    new DictionaryItem<string,string> { Key = "March", Value ="Hot dry season. Temperature range of spring in Laos may scare even salted travelers. At March and April air warms up to 30 – 40 °C (86-104 °F) on whole territory of the country. Even coolness of Mekong brings no relief for river is shallow. First two months of spring are part of dry and hot season. May marks beginning of longest wet and hot season. In fact it is the hottest month of a year. High temperatures are combined with extreme humidity and humongous amounts of rain. Staying in the country at this period is barely bearable. As dry season draws to a close, March sees the temperatures gradually rise throughout Laos, with the mercury pushing 30°C and even warmer in the south. Travel early in the month or head to the hills to escape the heat. " },

                    new DictionaryItem<string,string> { Key = "April", Value ="Hot dry season. Temperature range of spring in Laos may scare even salted travelers. At March and April air warms up to 30 – 40 °C (86-104 °F) on whole territory of the country. Even coolness of Mekong brings no relief for river is shallow. First two months of spring are part of dry and hot season. May marks beginning of longest wet and hot season. In fact it is the hottest month of a year. High temperatures are combined with extreme humidity and humongous amounts of rain. Staying in the country at this period is barely bearable.April in Laos is hot, hot, hot! Being the final month of Laos' dry season, days are typically sunny and rain-free, although the odd shower should be expected towards the end of the month.  " },

                    new DictionaryItem<string,string> { Key = "May", Value ="Rainy season. Whilst rain can be expected throughout Laos during May, it is typically intense and short lived and quickly replaced by blue skies and sunshine, although longer downpours are generally experienced in the south of the country. Temperatures remain high, with Luang Prabang and Vientiane experiencing average temperatures of 28°C, whilst further south in Pakse and the 4000 Islands highs of 35°C are the norm. Avoid the short, heavy showers and you will find that May is still a great month of the year to visit Laos as plenty of sunshine can still be expected and visitor numbers are lower than previous months. " },   
                    
                    new DictionaryItem<string,string> { Key = "June",Value ="Rainy season. June is considerable time to visit the country. Short yet intense monsoon showers are cousin vivid growth of local vegetation and daily temperature range is acceptable lying between 24 °C and 30 °C (75-86 °F). Weather conditions of June are more or less same." },   
                    
                    new DictionaryItem<string,string> { Key = "July", Value ="Rainy season. July is one of the wettest months of the year in Laos, although showers tend to be short and intense, lasting for a few hours rather than all-day downpours, and plenty of dry days can still be expected. July is considerable time to visit the country. Short yet intense monsoon showers are cousin vivid growth of local vegetation and daily temperature range is acceptable" },   
                    
                    new DictionaryItem<string,string> { Key = "August", Value ="Rainy season. Hot, wet and humid characterises the weather in Laos in August. Wet season reaches its peak in August, which is one of the wettest months of the year in Laos. There is a high probability of daily rainfall with showers increasing in severity. At August showers are reaching their peak. Aside personal discomfort this circumstance makes difficulties in moving around the country. Dirt roads are damped so main personal transport, moped, lose its relevance. But all concerns can’t prevail the fact that summer is rather warm than hot season which often becomes key factor in making decision to travel to Laos at summer." },   
                    
                    new DictionaryItem<string,string> { Key = "September", Value = "Rainy season. Autumn brings relative stability to weather in Laos. At September there is still rainy but gradually temperature goes to comfortable 25 °C (77 °F) and showers are subsiding by the end of October. September’s weather conditions in Laos are similar to August, with a high probability of rain. Although as the month rolls on and dry season approaches the intense downpours become more infrequent and less severe, and sunshine gradually replaces overcast skies." },   
                    
                    new DictionaryItem<string,string> { Key = "October",Value = "Rainy season. Laos' wet season finally draws to a close in October, with a higher chance of dry days towards the end of the month. Average temperatures sit comfortably around the mid 20°Cs. All-in-all October is a good time of year to visit Laos and beat the crowds who flock back from November. Autumn brings relative stability to weather in Laos. At September there is still rainy but gradually temperature goes to comfortable 25 °C (77 °F) and showers are subsiding by the end of October. The country is exceptionally rich on cultural and natural sights. Temples of the capital, lakes, waterfalls, caves and river rapids of Mekong are providing great basis for planning unforgettable vacation. And at October with its mild temperatures and little precipitation is perfect time for this. " },   
                    
                    new DictionaryItem<string,string> { Key = "November", Value = "Cool dry season. November sees the start of dry season throughout Laos: the chance of rain is minimal for the next five months and sunny days are the norm. Following several months of rain, the countryside is lush and green, and river levels remain high, making November a great month for river cruising. Pleasant average temperatures hover around 23°C in Vientiane and Luang Prabang, and 26°C in Pakse and the 4000 Islands, with peak temperatures not expected until March. At November in Laos weather acquires optimal state for main type of entertainment – excursions. The former is the most comfortable time to visit Laos particularly in November and December, the rivers are high enough to make river travel a breeze. However it's more expensive to travel in Laos during this period as it is the peak season." },

                    new DictionaryItem<string,string> { Key = "December", Value ="Cool dry season. December is one of the best months of the year to visit Laos. Throughout the country, days are typically dry and sunny, and the temperatures make travelling comfortable. December and January are part of dry and cool season. Central regions are having nice warm weather. Temperature range is between 22 and 25 °C (72-75 °F). Mountainous areas are naturally cooler with 15 to 21 °C (59-70 °F) depending on altitude of certain location with occasional rains.The former is the most comfortable time to visit Laos particularly in November and December, the rivers are high enough to make river travel a breeze. However it's more expensive to travel in Laos during this period as it is the peak season." }
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
                    new DictionaryItem<int,int> { Key = 3, Value =-1 },
                    new DictionaryItem<int,int> { Key = 4, Value =-1 },
                    new DictionaryItem<int,int> { Key = 5, Value =-1 },
                    new DictionaryItem<int,int> { Key = 6, Value =-1 },
                    new DictionaryItem<int,int> { Key = 7, Value =-1 },
                    new DictionaryItem<int,int> { Key = 8, Value  = -1 },
                    new DictionaryItem<int,int> { Key = 9, Value = -1 },
                    new DictionaryItem<int,int> { Key = 10, Value = 0 },
                    new DictionaryItem<int,int> { Key = 11, Value = 1 },
                    new DictionaryItem<int,int> { Key = 12, Value =1 },
                }

            }

        };
    }
}
