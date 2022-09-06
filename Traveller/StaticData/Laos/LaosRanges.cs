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

                Items = new List<DictionaryItem<string, string>>()
                {

                    new DictionaryItem<string,string> { Key = "January",Value ="Cool dry season" },

                    new DictionaryItem<string,string> { Key = "February", Value ="Cool dry season" },

                    new DictionaryItem<string,string> { Key = "March", Value ="Hot dry season" },

                    new DictionaryItem<string,string> { Key = "April", Value ="Hot dry season" },  
                    
                    new DictionaryItem<string,string> { Key = "May", Value ="Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "June",Value ="Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "July", Value ="Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "August", Value ="Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "September", Value = "Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "October",Value = "Rainy season" },   
                    
                    new DictionaryItem<string,string> { Key = "November", Value ="Cool dry season" },

                    new DictionaryItem<string,string> { Key = "December", Value ="Cool dry season" }
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
