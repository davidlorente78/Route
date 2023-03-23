using Traveller.Application.Dto;
using Traveller.Domain;

namespace RouteDataManager.ViewModels.Country
{
    public class SelectedCountryIndexViewModel
    {
        public IEnumerable<CountryDto> Countries { get; set; }

    }
}
