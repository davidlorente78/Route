using Application.Dto.Generic;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Application.Dto
{
    public class DestinationDto : GenericDto
    {
        public int DestinationCountryID { get; set; }
        public CountryDto DestinationCountry { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string LocalName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Photo")]
        public string Picture { get; set; }
    }
}
