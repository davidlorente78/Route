using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Cambodia
{
    public class CambodiaRanges
    {
        //public static RangeChar SeasonRange = new RangeChar
        //{ 
        //    Id = 'C',
        //    Description = new Dictionary<char, string>()
        //            {
        //            { 'A', "Más fresco y ventoso, con temperaturas casi mediterráneas. Es mejor reservar alojamiento por anticipado en Navidad y Año Nuevo.."},
        //            { 'M', "En abril y mayo, el termómetro alcanza los 40°C. Octubre y noviembre son magníficos para viajar: llueve menos pero aún no ha empezado la temporada seca.."},
        //            { 'B', "Los descuentos en alojamientos y las nubes hacen que sea una buena época para visitar los templos. La costa sur puede estar atestada de turistas occidentales." }
        //            },
        //    Values = new List<char> { 'A', 'A', 'M', 'M', 'B', 'B', 'B', 'B', 'B', 'M', 'A', 'A', }

        //};


        public static RangeChar SeasonRange = new RangeChar
        {

            entityFrameworkDictionarySeasonsDescriptions = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Más fresco y ventoso, con temperaturas casi mediterráneas. Es mejor reservar alojamiento por anticipado en Navidad y Año Nuevo.." },

                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "En abril y mayo, el termómetro alcanza los 40°C. Octubre y noviembre son magníficos para viajar: llueve menos pero aún no ha empezado la temporada seca.." },

                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Los descuentos en alojamientos y las nubes hacen que sea una buena época para visitar los templos. La costa sur puede estar atestada de turistas occidentales." },

                }

            }
           ,

            entityFrameworkDictionaryMonthSeason = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="A" },

                }

            }

        };


    }
}
