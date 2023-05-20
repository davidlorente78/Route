using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Application.Dto;

namespace RouteDataManager.ViewModels.RailwaySystem
{
    public class RailwayLineViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public char LineType { get; set; }
        public List<RailwayBranchDto> Branches { get; set; }
        public int CountryID { get; set; }
        public CountryDto Country { get; set; }
        public SelectList SelectListCountries { get; set; }
    }
}
