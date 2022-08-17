using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Vietnam
{
    public class VietnamRanges
    {
        private static List<char> SeasonDefinition = new List<char> { 'M', 'M', 'M', 'B', 'B', 'B', 'A', 'A', 'B', 'B', 'B', 'M', };

        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,

            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {
                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Los precios suben hasta un 50 % en la costa; se recomienda reservar hotel con antelación." },
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "Durante la celebración del Tet, todo el país se moviliza y los precios suben."},
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Probablemente la mejor época para recorrer el país." }
                }

            }
            ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {
                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue = SeasonDefinition.ElementAt(0).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue= SeasonDefinition.ElementAt(1).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue = SeasonDefinition.ElementAt(2).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue = SeasonDefinition.ElementAt(3).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue = SeasonDefinition.ElementAt(4).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue = SeasonDefinition.ElementAt(5).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue = SeasonDefinition.ElementAt(6).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue = SeasonDefinition.ElementAt(7).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "September",DictionaryValue = SeasonDefinition.ElementAt(8).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue = SeasonDefinition.ElementAt(9).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue = SeasonDefinition.ElementAt(10).ToString() },

                    new DictionaryItem<string> { DictionaryKey = "December",DictionaryValue = SeasonDefinition.ElementAt(11).ToString() },

                }

            }

        };

        public static RangeChar MonzonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'S', DictionaryValue = ""},
                    new DictionaryItem<char> { DictionaryKey = 'I', DictionaryValue =  ""}, 
                    new DictionaryItem<char> { DictionaryKey = 'V', DictionaryValue =  ""},
               }

            }
            ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {
                //https://www.roughguides.com/vietnam/when-to-go/
                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January",  DictionaryValue ="In January, cold winter weather hits the north. This is often accompanied by fine persistent mists, which could spoil your views at Ha Long Bay. There’s also the chance of ground frost in higher regions, or even a rare snowfall. Don’t let it put you off outdoor activities though – while January is the coldest month in mountainous areas, such as Sa Pa, rainfall is at its lowest, making perfect trekking conditions. Hanoi averages a pleasant 20ºC. The southern end of the country is firmly into the dry season come January, so it’s a good time to explore cities such as Ho Chi Minh. And for post-city downtime make for beaches within easy reach of the capital, such as at Phan Thiet and Mui Ne. It’s a fantastic time to try water-related activities, such as diving, around Phu Quoc. Nha Trang and Da Nang beaches also start to beckon in January, as the central coast sees the tail end of the rains." },
                    new DictionaryItem<string> { DictionaryKey = "February",  DictionaryValue = "Vietnam sees optimum weather conditions all-round in February. The south and the central coast, are perfect for beach bums, with just a smattering of rain perhaps on the beaches between Hoi An and Da Nang. If you can tear yourself away from the sands near Da Nang to dip into the back streets of the city, you’re in for some of the best street food in Vietnam. The north sees the chill lifting, leaving clear and warm days for hiking and exploring the region. Dominating the calendar is Tet, or the Lunar New Year, and the biggest festival in Vietnam. While it’s wonderfully festive throughout, note that much of the country shuts down during this period, such as restaurants and museums. Also, accommodation can be hard to come by, as the Vietnamese take their holidays, and the transport system is stretched." },
                    new DictionaryItem<string> { DictionaryKey = "March",  DictionaryValue ="In terms of the weather, March is perhaps the best month to visit Vietnam, especially if you want to see the whole country. Temperatures in the north are rising, making March a perfect time for adventure and trekking in the highlands and mountains. Clear skies around Ha Long Bay make it an ideal time to take a boat tour, stopping off at the beguiling Cat Ba Island. Dry weather means you can visit the awesome Phong Nha Caves in Phong Nha-ke Bang National Park, which boasts the world’s biggest cave. You can be sure of sunshine and hot days in the south, which means lazy days on the beaches and water-based activities are a must, also on beaches on the central coast, such as at Nha Trang. The central highlands are generally warm and dry now, so it’s a good time to visit Da Lat and surrounding areas." },
                    new DictionaryItem<string> { DictionaryKey = "April",  DictionaryValue ="Temperatures in the north are rising as summer approaches, and some rain is not uncommon. But it’s still very pleasant and great for hiking, with spring flowers in full bloom making the region especially beautiful. The centre of Vietnam entices with blue skies and sunshine, so make for charming town of Hoi An and the nearby beach of An Bang, and the broad sands at Da Nang. Further south, Nha Trang is at its best. Temperatures in the city of Hué are agreeable and the highlands experiences great weather at this time. There's a chance of some rain in southern Vietnam, but with mostly clear skies and temperatures hitting 31ºC it’s still great for sun worshippers on the south’s beautiful beaches." },
                    new DictionaryItem<string> { DictionaryKey = "May",  DictionaryValue ="The south is getting wetter as it moves into its monsoon season, but it’s easy to avoid the short afternoon downpours. The north is hotting up and seeing more rain, although it’s still mostly dry and great for exploring the great outdoors. The central coast is the place to be this month, with hot, sunny days." },
                    new DictionaryItem<string> { DictionaryKey = "June",  DictionaryValue ="The rainy season in the south is in full swing and floods are common, and rainfall is increasing in the central highlands. The north is heating up and getting wetter too, meaning trekking can be hazardous – so bring appropriate footwear and outer layers if that’s on your itinerary. But don’t let the rain deter you from visiting Vietnam. The central coast is at its best, so perfect for idling away some time on the beaches near Hoi An, Da Nang and Lang Co, and the south still has plenty of dry hours in the day. Hanoi in the north and the Mai Chau Valley are still mostly dry. Added to which, visitor numbers in Vietnam tend to be fewer in June." },
                    new DictionaryItem<string> { DictionaryKey = "July",  DictionaryValue ="July is a similar story to June: heavy downpours occurring at both ends of the country. Temperatures reach their peak in the north and the central coast is a searing 31ºC, on average. But if you don’t mind a roasting, it’s still a good month to hit the beaches, as there are still plenty of clear days, and the rain offsets some of the heat. Rain in the central highlands means trekking conditions are poor. Also, transport can be more complicated, sometimes washing out roads and cutting off the more remote villages. Hanoi tends to be very wet." },
                    new DictionaryItem<string> { DictionaryKey = "August",  DictionaryValue ="If you’re planning on trekking in Vietnam avoid visiting in August: the mountains of the north and the central highlands are experiencing peak rainfall now. And the deluge of rain at Ha Long Bay means you should forget about going on a boat tour this month. Conditions on the central coast are, on the whole, still pretty good, especially at Nha Trang, although the fine days are coming to an end. While the south is fully ensconced in its wet season, it’s not exactly a bad time to visit, with plenty of rain-free hours in the day to enjoy." },
                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="The north and south are experiencing a similar story: temperatures are high but it’s getting drier, opening up the possibility of trekking once more in the north, around Sa Pa. The central coast and central highlands, however, are getting very wet indeed, with storms on the horizon." },
                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="If trekking and other outdoor adventure activities are your bag and you’re wondering when to visit Vietnam, October is a great month. The sun puts its hat back on in the north, and dry weather makes for ideal conditions in Sa Pa and the Dong Van Karst Plateau Geopark in Ha Giang province. It’s a good time to explore the picturesque Mai Chau Valley, its rice fields a golden colour during the harvest season, against a backdrop of jagged mountains, and visit the minority White Thai villages. Sunbathing in central Vietnam is over, however, as the rain dumps down, and storms make it difficult to get around. It’s best to avoid Hoi An, in October and November, when serious flooding can mean water in the streets can be knee- or waist high. Meanwhile, the south is drying up, and warming up. It’s a great month to visit the Mekong Delta and its floating markets." },
                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="Balmy temperatures in the south and favourable conditions in the north make this an ideal month to visit either end of the country. Take your pick of the beaches in the south, or go trekking in the north. November is also the best time of year to visit Vietnam for a cruise at Ha Long Bay. It’s a different picture along the central coast. The wet season starts with a flourish around Nha Trang, and be warned that when the northeasterly winter monsoon hits, the riptides between Da Nang and Hoi An become particularly dangerous." },
                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="Most of Vietnam enjoys dry conditions and basks in sunshine by December. Central Vietnam is the exception, which is gradually emerging from its rainy season. So it’s a good time to head to the southern coast if you want to soak up some rays and rack up some time on Vietnam’s gorgeous beaches. Beaches such as Mui Ne, or on the island of Phu Quoc are great in this month.  It’s also a good time to visit Ho Chi Minh City, with temperatures averaging a comfortable 26ºC.  If you’re planning a Christmas getaway be aware that things get booked up way in advance, so plan ahead.  Outdoor activities in the north are good in December. It is somewhat chilly, however, especially in the mountains – so pack extra layers.  " }
                }

            }

        };
    };


}

