using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Malasia
{
    public class ThailandRanges
    {
        //public static RangeChar SeasonRange = new RangeChar
        //{
        //    Id = 'T',
        //    Description = new Dictionary<char, string>()
        //            {
        //            { 'A', "Navidad y Año Nuevo son las épocas más turísticas y caras."},
        //            { 'M', "El norte y la costa del golfo son ideales en septiembre y octubre."},
        //            { 'B', "Algunas islas cierran y, según el tiempo, circulan menos barcos; se recomienda cierto margen de maniobra." }
        //            },
        //    Values = new List<char> { 'A', 'A', 'A', 'M', 'M', 'M', 'B', 'B', 'M', 'M', 'A', 'A', }

        //};

        public static RangeChar SeasonRange = new RangeChar
        {

            entityFrameworkDictionarySeasonsDescriptions = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Navidad y Año Nuevo son las épocas más turísticas y caras."},
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "El norte y la costa del golfo son ideales en septiembre y octubre."},
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Algunas islas cierran y, según el tiempo, circulan menos barcos; se recomienda cierto margen de maniobra." }
                }

            }
            ,

            entityFrameworkDictionaryMonthSeason = new EntityFrameworkDictionary<string>()
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


    }
}
