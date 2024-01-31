using Application.Dto.Generic;

namespace Traveller.Application.Dto
{
    public class AirlineTypeDto : GenericDto
    {
        public char? Code { get; set; }
        public string Description { get; set; }
    }
}
