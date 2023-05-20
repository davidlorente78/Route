using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels
{
    public class StationIndexViewModel
    {
        public IEnumerable<RailwayStationDto> Stations { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListLines { get; set; }
        public RailwayLineDto FilterLine { get; set; } = new RailwayLineDto();
        public CountryDto FilterCountry { get; set; } = new CountryDto() { Id = 3 };
    }
}
