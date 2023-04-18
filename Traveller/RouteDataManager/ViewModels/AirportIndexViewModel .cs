using Application.Dto;
using Domain.Transport.Aviation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels
{
    public class AirportIndexViewModel
    {
        public IEnumerable<AirportDto> Airports { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListAirportTypes { get; set; }

        public AirportTypeDto FilterAirportType { get; set; } = new AirportTypeDto() { Id = 1 };
        public CountryDto FilterCountry { get; set; } = new CountryDto() { Id = 1 };

    }
}
