using Application.Dto.Generic;
using System.Collections.Generic;

namespace Traveller.Application.Dto
{
    public class RailwayStationDto : GenericDto
    {
        public string Name { get; set; }
        public string LocalName { get; set; }
        public char Type { get; set; }
        public string Remarks { get; set; }
        public virtual List<DestinationDto> Destinations { get; set; } = new List<DestinationDto>();
    }
}
