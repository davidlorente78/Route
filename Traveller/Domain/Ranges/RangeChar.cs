using Domain.EntityFrameworkDictionary;
using Traveller.Domain;

namespace Domain.Ranges
{
    public class RangeChar 
    {
        public int RangeCharID { get; set; }

        public string RangeType { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
       
        public RangeType? rangeType { get; set; }
        public EntityFrameworkDictionary<char> entityFrameworkDictionaryEntityDescriptions { get; set; }
        public EntityFrameworkDictionary<string> entityFrameworkDictionaryMonthEntityDescriptionKey { get; set; }
    }
}
