using Application.Dto;
using Application.Dto.Generic;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Application.Dto
{
    public class DestinationDto : GenericDto
    {
        public int CountryID { get; set; }
        public CountryDto Country { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string LocalName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Photo")]
        public string Picture { get; set; }
        public int DestinationTypeID { get; set; }
        
        [Display(Name = "Has Railway Station")]
        public bool HasRailwayStation { get; set; }
    }
}
