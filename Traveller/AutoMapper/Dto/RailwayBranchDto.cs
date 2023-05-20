using Application.Dto.Generic;
using System.Collections.Generic;

namespace Traveller.Application.Dto
{
    public class RailwayBranchDto : GenericDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool MainBranch { get; set; }
        public int RailwayLineID { get; set; }
        public RailwayLineDto RailwayLine { get; set; }
        public List<RailwayStationDto> Stations { get; set; }
    }
}
