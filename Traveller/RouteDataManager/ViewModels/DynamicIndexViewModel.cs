using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class DynamicIndexViewModel
    {
        public ICollection<string> CountryNames = new List<string>();
        public ICollection<int> DestinationCountryCount =  new List<int>();
        public ICollection<int> DestinationAirportsCount = new List<int>();
    }
}
