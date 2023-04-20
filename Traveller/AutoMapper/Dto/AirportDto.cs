using Application.Dto.Generic;

namespace Traveller.Application.Dto
{
    public class AirportDto : GenericDto
    {
        public int AirportTypeId { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public int AirportCountryId { get; set; }
        public string Description { get; set; }
    }
}
