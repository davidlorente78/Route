using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class DynamicIndexData
    {
        public ICollection<string> CountryNames = new List<string>();
        public ICollection<int> DestinationCountryCount =  new List<int>();
    }
}
