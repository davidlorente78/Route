using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels.RailwaySystem
{
    public class RailwayStationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public char Type { get; set; }
        public string Remarks { get; set; }
        public virtual List<DestinationDto> Destinations { get; set; } = new List<DestinationDto>();
        public int CountryID { get; set; }
        public CountryDto Country { get; set; }
        public SelectList SelectListCountries { get; set; }
        public SelectList SelectListLines { get; set; }

    }
}
