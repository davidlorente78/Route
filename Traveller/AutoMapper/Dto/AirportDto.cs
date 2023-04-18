using Application.Dto;
using Application.Dto.Generic;
using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.Application.Dto
{
    public class AirportDto : GenericDto
    {
        public int AirportID { get; set; }
        public AirportTypeDto AirportType { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; }
        public int AirportCountryID { get; set; }
        public virtual Country AirportCountry { get; set; }
        public string Description { get; set; }
    }
}
