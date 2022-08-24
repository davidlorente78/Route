using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Malaysia
{
    public class MalaysiaRanges
    {
        /// <summary>
        /// Use this string to define faster Dictionary Items above
        /// </summary>
        private static string SeasonDefinition = "AABBBBMMMMMB";


        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "The end-of-year school vacations, followed by Chinese New Year, drive up prices and it pays to book transport and accommodation. It's monsoon season on the east coast of Peninsular Malaysia and western Sarawak." },

                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "From July to August you will be competing with visitors from the Gulf states escaping the heat; it's the so-called Arabian season. It is monsoon season on the west coast of peninsular Malaysia until September." },

                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "It is advisable to avoid the worst rainy and humid season. That's when it's the quietest time to enjoy certain very touristy places." },

                }

            }
            ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {
                    //TODO
                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue = SeasonDefinition.ElementAt(0).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="B" },

                }

            }

        };

        //Malaysia has two monsoon seasons and therefore its dry seasons are different too. The east-coast dry season runs from March until September, and the west-coast dry season runs from October to April.

        //https://www.experiencetravelgroup.com/weather/when-to-go-to-malaysia

        public static RangeChar MonsoonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'E', DictionaryValue = "The east-coast dry season runs from March until September." },
                    new DictionaryItem<char> { DictionaryKey = 'W', DictionaryValue = "The west-coast dry season runs from October to April"},
                    new DictionaryItem<char> { DictionaryKey = 'I', DictionaryValue = "The east of Malaysia, including islands like Tioman, Redang and the Perhentian Islands, see heavy rains between November and February. These showers can be longer and heavier than those in the west, so we generally advise travellers to avoid the east of Malaysia at this time. ." },
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "The west of Malaysia, where you’ll find popular beach spots like Langkawi and Pangkor, has heavier rain in September and October. However, it is still possible to experience a lovely beach stay with little more than a short sharp downpour at this time."},


                }
            }
         ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January",DictionaryValue ="With the west coast basking in sunshine, it’s a fantastic time to visit Langkawi, Penang, Kuala Lumpur, Malacca and the Cameron highlands. On the east coast, however, the rainy season ensues so is best avoided. The east of Malaysia, including islands like Tioman, Redang and the Perhentian Islands, see heavy rains between November and February. These showers can be longer and heavier than those in the west, so we generally advise travellers to avoid the east of Malaysia at this time. " },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="With the west coast basking in sunshine, it’s a fantastic time to visit Langkawi, Penang, Kuala Lumpur, Malacca and the Cameron highlands. On the east coast, however, the rainy season ensues so is best avoided. The east of Malaysia, including islands like Tioman, Redang and the Perhentian Islands, see heavy rains between November and February. These showers can be longer and heavier than those in the west, so we generally advise travellers to avoid the east of Malaysia at this time. " },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="With the west coast basking in sunshine, it’s a fantastic time to visit Langkawi, Penang, Kuala Lumpur, Malacca and the Cameron highlands. On the east coast, however, the rainy season ensues so is best avoided." },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="In April, weather in Malaysia is good across the country. The west and east coasts both enjoy lovely weather. The cultural centres of Kuala Lumpur, Cameron Highlands and Penang might have a few odd showers but not enough to affect your trip; they might even be a welcome relief from the humidity." },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="The East Coast enjoys dry weather and glorious sunshine. The sea is relatively calm, perfect for snorkelling explorations around coral reefs. The west coast, on the other hand, is now in its rainy season, so heavy downpours should be expected, albeit short-lived." },

                    new DictionaryItem<string> { DictionaryKey = "June",DictionaryValue ="The East Coast enjoys dry weather and glorious sunshine. The sea is relatively calm, perfect for snorkelling explorations around coral reefs. The west coast, on the other hand, is now in its rainy season, so heavy downpours should be expected, albeit short-lived." },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="The East Coast enjoys dry weather and glorious sunshine. The sea is relatively calm, perfect for snorkelling explorations around coral reefs. The west coast, on the other hand, is now in its rainy season, so heavy downpours should be expected, albeit short-lived." },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="The East Coast enjoys dry weather and glorious sunshine. The sea is relatively calm, perfect for snorkelling explorations around coral reefs. The west coast, on the other hand, is now in its rainy season, so heavy downpours should be expected, albeit short-lived." },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue = "The climate on the east coast remains dry with relatively low humidity, sunshine and little rain. A northeast monsoon begins to blow, bringing slightly rougher sea conditions and a cooler temperature than the summer months. The west coast wet season declines although rain can still come. In particular, Penang and Langkawi can experience heavy storms. The west of Malaysia, where you’ll find popular beach spots like Langkawi and Pangkor, has heavier rain in September and October. However, it is still possible to experience a lovely beach stay with little more than a short sharp downpour at this time." },

                    new DictionaryItem<string> { DictionaryKey = "October",DictionaryValue = "The climate on the east coast remains dry with relatively low humidity, sunshine and little rain. A northeast monsoon begins to blow, bringing slightly rougher sea conditions and a cooler temperature than the summer months. The west coast wet season declines although rain can still come. In particular, Penang and Langkawi can experience heavy storms. The west of Malaysia, where you’ll find popular beach spots like Langkawi and Pangkor, has heavier rain in September and October. However, it is still possible to experience a lovely beach stay with little more than a short sharp downpour at this time." },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="Dry and sunny weather returns to the west of Malaysia marking the start of the peak season. You can expect reliably hot weather, with long periods of sunshine on the west coast throughout this period. On the east coast, however, the monsoon brings heavy rains. Many resorts in eastern Malaysia close during this period, reopening again in March/April time. The east of Malaysia, including islands like Tioman, Redang and the Perhentian Islands, see heavy rains between November and February. These showers can be longer and heavier than those in the west, so we generally advise travellers to avoid the east of Malaysia at this time. " },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="As ever, the weather in Malaysia in December is a decidedly mixed bag. It’s excellent on the west coast, with dry weather perfect for a beach stay and the less extreme heat makes it a perfect time for exploring too. On the east coast, however, downpours and storms are frequent and many resorts remain firmly closed. The east of Malaysia, including islands like Tioman, Redang and the Perhentian Islands, see heavy rains between November and February. These showers can be longer and heavier than those in the west, so we generally advise travellers to avoid the east of Malaysia at this time. " }
                }

            }

        };
    }
}
