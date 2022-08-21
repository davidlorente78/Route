using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Nepal
{
    public class NepalRanges
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
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Visiting Kathmandu Valley during the monsoon is not advised as one may not be able to explore the attractions due to heavy rains and it is also dangerous to trek during this time of the year. The monsoon in Kathmandu ends around the month of September." }
                }

            }
            ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="X" },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="X" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="X" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="X" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="X" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="A" },

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

                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "Monsoon season." },
                
               }

            }
            ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="From late December through to February, Nepal's weather is pleasant during the day but temperatures drop significantly at night-time; especially in the mountains. January is the coldest month, but fewer visitors results in quieter sightseeing opportunities. Many hotels and lodges offer fireplaces, blankets and hot water bottles to keep you cosy. January and February can be very cold, especially at night, with average temperatures of 6°C in Namche Bazaar. But you’ll be rewarded with clear skies, incredible panoramas and quieter trekking trails, as there are fewer visitors. High altitude trekking is not recommended at this time. Kathmandu : January, the same as December, is another enjoyable winter month in Kathmandu, Nepal, with an average temperature ranging between max 19.1°C (66.4°F) and min 2.4°C (36.3°F). January is the coldest month, with an average high-temperature of 19.1°C (66.4°F) and an average low-temperature of 2.4°C (36.3°F). "},
                    new DictionaryItem<string> { DictionaryKey = "February",  DictionaryValue ="From late December through to February, Nepal's weather is pleasant during the day but temperatures drop significantly at night-time; especially in the mountains. January is the coldest month, but fewer visitors results in quieter sightseeing opportunities. Many hotels and lodges offer fireplaces, blankets and hot water bottles to keep you cosy.January and February can be very cold, especially at night, with average temperatures of 6°C in Namche Bazaar. But you’ll be rewarded with clear skies, incredible panoramas and quieter trekking trails, as there are fewer visitors. High altitude trekking is not recommended at this time. Kathmandu : The last month of the winter, February, is a pleasant month in Kathmandu, Nepal, with an average temperature ranging between max 21.4°C (70.5°F) and min 4.5°C (40.1°F). In Kathmandu, Nepal, the average high-temperature in February is relatively the same as in January - a pleasant 21.4°C (70.5°F)."},
                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="March marks the beginning of spring, when temperatures increase and rhododendrons bloom. Days are longer during March and April, making them perfect for trekking, although temperatures are still cool at night. It's a popular time to travel, so plan well in advance. Kathmandu : The first month of the spring, March, is a warm month in Kathmandu, Nepal, with temperature in the range of an average low of 8.2°C (46.8°F) and an average high of 25.3°C (77.5°F). In March, the average high-temperature slightly increases from an agreeable 21.4°C (70.5°F) in February to a warm 25.3°C (77.5°F)." },
                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="March marks the beginning of spring, when temperatures increase and rhododendrons bloom. Days are longer during March and April, making them perfect for trekking, although temperatures are still cool at night. It's a popular time to travel, so plan well in advance. Kathmandu : April, the same as March, is a moderately hot spring month in Kathmandu, Nepal, with an average temperature varying between 11.7°C (53.1°F) and 28.2°C (82.8°F). In Kathmandu, the average high-temperature in April is practically the same as in March - a still warm 28.2°C (82.8°F). "},
                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="May is one of the warmest months of the year but will bring cloud and showers before the monsoon arrives. Late spring in May is a beautiful time to travel, with the rhododendrons bursting into bloom. Heat and humidity levels build, with temperatures climbing to 35°C in Chitwan National Park. Kathmandu : May, the last month of the spring in Kathmandu, is another warm month, with an average temperature fluctuating between 28.7°C (83.7°F) and 15.7°C (60.3°F). In Kathmandu, the average high-temperature in May is relatively the same as in April - a still moderately hot 28.7°C (83.7°F)." },
                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="The monsoon season arrives in June and lasts until the end of August, with the clouds obscuring the glorious mountain views. The heavy rain and landslides make travel difficult and many places close down, so the country is best avoided at this time. The monsoon season occurs from June through to August. Days are warm (up to 30°C), wet and with high humidity. Due to Nepal’s topography, rains often occur at night, resulting in beautiful morning scenery. Although we’d advise against trekking at this time of year, city sightseeing is still possible and quieter than peak periods. Kathmandu : The first month of the summer, June, is also a moderately hot month in Kathmandu, Nepal, with temperature in the range of an average low of 19.1°C (66.4°F) and an average high of 29.1°C (84.4°F). The warmest month is June, with an average high-temperature of 29.1°C (84.4°F) and an average low-temperature of 19.1°C (66.4°F). In June, the average heat index is computed to be a tropical 33.5°C (92.3°F)."},
                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="The monsoon season arrives in June and lasts until the end of August, with the clouds obscuring the glorious mountain views. The heavy rain and landslides make travel difficult and many places close down, so the country is best avoided at this time. The monsoon season occurs from June through to August. Days are warm (up to 30°C), wet and with high humidity. Due to Nepal’s topography, rains often occur at night, resulting in beautiful morning scenery. Although we’d advise against trekking at this time of year, city sightseeing is still possible and quieter than peak periods. Kathmandu : July, the same as June, is another warm summer month in Kathmandu, Nepal, with an average temperature fluctuating between 28.4°C (83.1°F) and 20.2°C (68.4°F). In Kathmandu, Nepal, the average high-temperature in July is relatively the same as in June - a still moderately hot 28.4°C (83.1°F). "},
                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="The monsoon season arrives in June and lasts until the end of August, with the clouds obscuring the glorious mountain views. The heavy rain and landslides make travel difficult and many places close down, so the country is best avoided at this time. The monsoon season occurs from June through to August. Days are warm (up to 30°C), wet and with high humidity. Due to Nepal’s topography, rains often occur at night, resulting in beautiful morning scenery. Although we’d advise against trekking at this time of year, city sightseeing is still possible and quieter than peak periods. Kathmandu : The last month of the summer, August, is also a moderately hot month in Kathmandu, Nepal, with an average temperature varying between 28.7°C (83.7°F) and 20°C (68°F). In August, the average high-temperature is relatively the same as in July - a still warm 28.7°C (83.7°F)."},
                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="As the monsoon dissipates in September, Nepal welcomes beautiful clear skies, fresh air and incredible views. October and November are two of the best months to visit as dry days make trekking easier and offer good visibility. The verdant landscapes following the rains are ideal for photographers. Kathmandu : September, the first month of the autumn in Kathmandu, is still a warm month, with an average temperature ranging between min 18.5°C (65.3°F) and max 28.1°C (82.6°F). In Kathmandu, the average high-temperature in September is almost the same as in August - a still warm 28.1°C (82.6°F)."},
                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="As the monsoon dissipates in September, Nepal welcomes beautiful clear skies, fresh air and incredible views. October and November are two of the best months to visit as dry days make trekking easier and offer good visibility. The verdant landscapes following the rains are ideal for photographers. The best time to visit Nepal is between October and December, when the skies are a clear blue and the views spectacular. The weather remains dry until about April, with temperatures varying between regions. Kathmandu : October, the same as September, is a moderately hot autumn month in Kathmandu, Nepal, with an average temperature varying between 26.8°C (80.2°F) and 13.4°C (56.1°F). In October, the average high-temperature is relatively the same as in September - a still warm 26.8°C (80.2°F)."},
                    new DictionaryItem<string> { DictionaryKey = "November",DictionaryValue ="As the monsoon dissipates in September, Nepal welcomes beautiful clear skies, fresh air and incredible views. October and November are two of the best months to visit as dry days make trekking easier and offer good visibility. The verdant landscapes following the rains are ideal for photographers. The best time to visit Nepal is between October and December, when the skies are a clear blue and the views spectacular. The weather remains dry until about April, with temperatures varying between regions.Kathmandu : The last month of the autumn, November, is also a moderately hot month in Kathmandu, Nepal, with temperature in the range of an average high of 23.6°C (74.5°F) and an average low of 7.8°C (46°F). In Kathmandu, the average high-temperature in November marginally drops from 26.8°C (80.2°F) in October to a still moderately hot 23.6°C (74.5°F). " },
                    new DictionaryItem<string> { DictionaryKey = "December",  DictionaryValue ="From late December through to February, Nepal's weather is pleasant during the day but temperatures drop significantly at night-time; especially in the mountains. January is the coldest month, but fewer visitors results in quieter sightseeing opportunities. Many hotels and lodges offer fireplaces, blankets and hot water bottles to keep you cosy. The best time to visit Nepal is between October and December, when the skies are a clear blue and the views spectacular. The weather remains dry until about April, with temperatures varying between regions. Kathmandu : The first month of the winter, December, is still a pleasant month in Kathmandu, Nepal, with temperature in the range of an average high of 20.2°C (68.4°F) and an average low of 3.7°C (38.7°F). In December, the average high-temperature slightly decreases from a moderately hot 23.6°C (74.5°F) in November to a pleasant 20.2°C (68.4°F)."},

                }

            }

        };
    }
}
