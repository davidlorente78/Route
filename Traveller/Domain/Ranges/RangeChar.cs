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

        //Refector TODO
        public EntityFrameworkDictionary<char,string>? EntityKey_Description { get; set; }
        public EntityFrameworkDictionary<string,string>? EntityDescription_ByMonth { get; set; }
        public EntityFrameworkDictionary<string,string>? EntityKey_ByMonth { get; set; }
        public EntityFrameworkDictionary<int,int>? EntityEvaluator_ByMonth { get; set; }        
    }
}
