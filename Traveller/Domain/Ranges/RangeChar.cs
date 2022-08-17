using Domain.EntityFrameworkDictionary;
using Traveller.Domain;

namespace Domain.Ranges
{
    public class RangeChar 
    {
        public int RangeCharID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }       
        public RangeType RangeType { get; set; }
        public EntityFrameworkDictionary<char>? EntityKey_Description { get; set; }
        public EntityFrameworkDictionary<string>? EntityDescription_ByMonth { get; set; }
        public EntityFrameworkDictionary<string>? EntityKey_ByMonth { get; set; }
    }
}
