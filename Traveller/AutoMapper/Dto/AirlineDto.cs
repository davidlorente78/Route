using Application.Dto.Generic;
using Microsoft.AspNetCore.Http;


namespace Traveller.Application.Dto
{
    public class AirlineDto : GenericDto
    {
        public string IATACode { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public int? MainAirportID { get; set; }
        public int AirlineTypeID { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Url { get; set; }
        public string ExistingImage { get; set; }
        public IFormFile MapPicture { get; set; }
    }
}
