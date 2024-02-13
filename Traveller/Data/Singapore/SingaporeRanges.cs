using Domain.EntityFrameworkDictionary;
using Domain.Ranges;
using Data.EntityTypes;

namespace Data.Sinpagore
{
    public class SingaporeRanges
    {
        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char, string>()
            {
                Items = new List<DictionaryItem<char, string>>()
                {
                    new DictionaryItem<char,string> { Key = 'X', Value = ""},
                }
            },

            EntityKey_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string,string> { Key = "January", Value ="X" },

                    new DictionaryItem<string,string> { Key = "February", Value ="X" },

                    new DictionaryItem<string,string> { Key = "March", Value ="X" },

                    new DictionaryItem<string,string> { Key = "April", Value ="X" },

                    new DictionaryItem<string,string> { Key = "May", Value ="X" },

                    new DictionaryItem<string,string> { Key = "June", Value ="X" },

                    new DictionaryItem<string,string> { Key = "July", Value ="X" },

                    new DictionaryItem<string,string> { Key = "August", Value ="X" },

                    new DictionaryItem<string,string> { Key = "September", Value ="X" },

                    new DictionaryItem<string,string> { Key = "October", Value ="X" },

                    new DictionaryItem<string,string> { Key = "November", Value ="X" },

                    new DictionaryItem<string,string> { Key = "December", Value ="X" },
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
                    new DictionaryItem<char,string> { Key = 'X', Value = "X." },
               }
            },
            EntityDescription_ByMonth = new EntityFrameworkDictionary<string, string>()
            {
                Items = new List<DictionaryItem<string, string>>()
                {
                    new DictionaryItem<string,string> { Key = "January", Value =""},
                    new DictionaryItem<string,string> { Key = "February",  Value =""},
                    new DictionaryItem<string,string> { Key = "March", Value =""},
                    new DictionaryItem<string,string> { Key = "April", Value =""},
                    new DictionaryItem<string,string> { Key = "May", Value =""},
                    new DictionaryItem<string,string> { Key = "June",  Value =""},
                    new DictionaryItem<string,string> { Key = "July", Value =""},
                    new DictionaryItem<string,string> { Key = "August",  Value =""},
                    new DictionaryItem<string,string> { Key = "September",  Value =""},
                    new DictionaryItem<string,string> { Key = "October",  Value =""},
                    new DictionaryItem<string,string> { Key = "November", Value =""},
                    new DictionaryItem<string,string> { Key = "December",  Value =""},
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
                    new DictionaryItem<int,int> { Key = 3, Value =1 },
                    new DictionaryItem<int,int> { Key = 4, Value =1 },
                    new DictionaryItem<int,int> { Key = 5, Value =1 },
                    new DictionaryItem<int,int> { Key = 6, Value =1 },
                    new DictionaryItem<int,int> { Key = 7, Value =-1 },
                    new DictionaryItem<int,int> { Key = 8, Value  = 1 },
                    new DictionaryItem<int,int> { Key = 9, Value = 1 },
                    new DictionaryItem<int,int> { Key = 10, Value = 1 },
                    new DictionaryItem<int,int> { Key = 11, Value = 1 },
                    new DictionaryItem<int,int> { Key = 12, Value =1 },
                }
            }
        };
    }
}
