using Application.Dto;
using Application.Dto.Generic;
using System.Collections.Generic;

namespace Traveller.Application.Dto
{

    public class RailwayLineDto : GenericDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public char LineType { get; set; }
        public List<RailwayBranchDto> Branches { get; set; }
        public int CountryID { get; set; }
        public CountryDto Country { get; set; }
    }
}
