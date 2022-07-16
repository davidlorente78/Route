using Domain.EntityFrameworkDictionary;
using Traveller.Domain;

namespace Domain.Ranges
{
    public class RangeChar 
    {
        public int RangeCharID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        /// <summary>
        /// Se ha modificado esta lista de valores por otro diccionario compatible con EF
        //Values = new    { 'A', 'A', 'B', 'B', 'B', 'B', 'M', 'M', 'M', 'M', 'M', 'B', },
        /// </summary>
        //public ICollection<EntityFrameworkChar> Values { get; set; }
        public RangeType? rangeType { get; set; }
        public EntityFrameworkDictionary<char> entityFrameworkDictionarySeasonsDescriptions { get; set; }
        public EntityFrameworkDictionary<string> entityFrameworkDictionaryMonthSeason { get; set; }
    }
}
