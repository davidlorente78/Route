using Application.Dto.Generic;
using System.Collections.Generic;

namespace Traveller.Application.Dto
{
    public class DestinationTypeDto : GenericDto
    {
        public List<DestinationDto> Destinations { get; set; }
        public string Description { get;  set; }
    }
}
