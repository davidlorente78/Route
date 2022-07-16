using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Malasia
{
    public class VietnamRanges


    {

        private static List<char> SeasonDefinition = new List<char> { 'M', 'M', 'M', 'B', 'B', 'B', 'A', 'A', 'B', 'B', 'B', 'M', };

        public static RangeChar SeasonRange = new RangeChar
        {
            //Id = 'V',
            //Description = new Dictionary<char, string>()
            //        {
            //        { 'A', "Los precios suben hasta un 50 % en la costa; se recomienda reservar hotel con antelación."},
            //        { 'M', "Durante la celebración del Tet, todo el país se moviliza y los precios suben."},
            //        { 'B', "Probablemente la mejor época para recorrer el país." }
            //        },
            //Values = new List<char> { 'M', 'M', 'M', 'B', 'B', 'B', 'A', 'A', 'B', 'B', 'B', 'M', }




            entityFrameworkDictionarySeasonsDescriptions = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {
                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Los precios suben hasta un 50 % en la costa; se recomienda reservar hotel con antelación." },
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "Durante la celebración del Tet, todo el país se moviliza y los precios suben."},
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Probablemente la mejor época para recorrer el país." }
                }

            }
            ,

            entityFrameworkDictionaryMonthSeason = new EntityFrameworkDictionary<string>()
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

    };


}

