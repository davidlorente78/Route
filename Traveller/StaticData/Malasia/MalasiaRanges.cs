using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Malasia
{
    public class MalasiaRanges
    {

        private static string SeasonDefinition = "AABBBBMMMMMB";


        public static RangeChar SeasonRange = new RangeChar
        {

            entityFrameworkDictionarySeasonsDescriptions = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Las vacaciones escolares de fin de año, seguidas del Año Nuevo chino, elevan los precios y conviene reservar el transporte y el alojamiento. Es temporada del monzón en la costa este de la Malasia peninsular y el oeste de Sarawak." },

                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "De julio a agosto se competirá con los visitantes de los estados del Golfo que escapan del calor; es la llamada “temporada árabe”. Es temporada del monzón en la costa oeste de la Malasia peninsular hasta septiembre." },

                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Conviene evitar la peor época de lluvias y humedad.Es cuando más tranquilo se puede disfrutar de ciertos lugares muy turísticos." },

                }

            }
            ,

            entityFrameworkDictionaryMonthSeason = new EntityFrameworkDictionary<string>()
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




        //Values = new List<EntityFrameworkChar > { 

        //    new EntityFrameworkChar() {  c= 'A' },
        //    new EntityFrameworkChar() {  c= 'A' },
        //    new EntityFrameworkChar() {  c= 'B' },
        //    new EntityFrameworkChar() {  c= 'B' },
        //    new EntityFrameworkChar() {  c= 'B' },
        //    new EntityFrameworkChar() {  c= 'B' },
        //    new EntityFrameworkChar() {  c= 'M' },
        //    new EntityFrameworkChar() {  c= 'M' },
        //    new EntityFrameworkChar() {  c= 'M' },
        //    new EntityFrameworkChar() {  c= 'M' },
        //    new EntityFrameworkChar() {  c= 'M' },
        //    new EntityFrameworkChar() {  c= 'B' },

        // } 

        // ,



    }
}
