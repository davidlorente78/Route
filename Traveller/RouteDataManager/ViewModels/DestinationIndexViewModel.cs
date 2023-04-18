using Application.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels
{
    public class DestinationIndexViewModel
    {
        public IEnumerable<DestinationDto> Destinations { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListDestinationTypes { get; set; }
        public DestinationTypeDto FilterDestinationType { get; set; } = new DestinationTypeDto() { Id = 3 };
        public CountryDto FilterCountry { get; set; } = new CountryDto() { Id = 3 };
    }
}
