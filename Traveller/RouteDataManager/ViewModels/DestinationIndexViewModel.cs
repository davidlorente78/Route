using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class DestinationIndexViewModel
    {
        public IEnumerable<Traveller.Domain.Destination> Destinations { get; set; }

        public Country FilterCountry { get; set; } = new Country() { CountryID = 1 };
    }
}
