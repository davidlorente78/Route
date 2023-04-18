using Application.Dto.Generic;

namespace Application.Dto
{
    public class AirportTypeDto : GenericDto
    {
        public char? Code { get; set; }
        public string Description { get; set; }
    }
}
