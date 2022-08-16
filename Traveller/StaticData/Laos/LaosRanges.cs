using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Laos
{
    public class LaosRanges
    {

        private static List<char> SeasonDefinition = new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'M', 'M', 'B', 'B', 'A', 'A', };

        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = "SeasonRange",
            entityFrameworkDictionaryEntityDescriptions = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {
                      new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Los precios suben hasta un 50 % en la costa; se recomienda reservar hotel con antelación."},
                      new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue =  "Los paisajes verdes son preciosos. Temporada preferida por los viajeros españoles, además de mochileros de todo el mundo."},
                      new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "En abril y mayo hace calor, con temperaturas de hasta 40ºC. En septiembre y octubre puede llover bastante, aunque los diluvios van acompañados de increíbles formaciones de nubes. " }

                  }
            }
          ,

            entityFrameworkDictionaryMonthEntityDescriptionKey = new EntityFrameworkDictionary<string>()
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


    }
}
