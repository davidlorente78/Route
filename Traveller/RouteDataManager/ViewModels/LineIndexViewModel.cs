using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels
{
    public class LineIndexViewModel
    {
        public IEnumerable<RailwayLineDto> Lines { get; set; }
        public SelectList SelectListCountries { get; set; }
        public CountryDto FilterCountry { get; set; } = new CountryDto() { Id = 3 };
    }
}
