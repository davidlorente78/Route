using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels.RailwaySystem
{
    public class RailwayBranchViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool MainBranch { get; set; }
        public int RailwayLineID { get; set; }
        public RailwayLineDto RailwayLine { get; set; }
        public List<RailwayStationDto> Stations { get; set; }
        public SelectList SelectListCountries { get; set; }
    }
}
