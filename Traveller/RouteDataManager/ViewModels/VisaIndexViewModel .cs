using Application.Dto;
using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class VisaIndexViewModel
    {
        public IEnumerable<VisaDto> Visas { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListNationalities{ get; set; }
        public NationalityDto FilterNationality { get; set; } = new NationalityDto() {  Id = 1};
        public CountryDto FilterCountry { get; set; } = new CountryDto() { Id = 3 };
    }
}
