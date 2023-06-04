using Domain.Ranges;

namespace RouteDataManager.ViewModels
{
    public class RoundItineraryIndexViewModel
    {
        public RoundItineraryIndexViewModel()
        {

        }

        public int RoutesFoundCount { get; set; }

        public List<Traveller.Domain.Country> FilterCountry { get; set; } = new List<Traveller.Domain.Country>();

        public List<string> CountryReport { get; set; } = new List<string>();

        public List<Month> Months { get; set; }

        public int ShowingIndex { get; set; }
    }
}
