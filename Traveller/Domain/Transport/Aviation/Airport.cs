using Domain.Generic;
using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Aviation
{
    public class Airport :  Entity
    {
        [Required]
        [Display(Name = "Airport Type")]
        public AirportType AirportType { get; set; }
        public int AirportTypeId { get; set; }
        public virtual Country AirportCountry { get; set; }
        public int AirportCountryId { get; set; }

        [Display(Name = "IATA Code")]
        public string IATACode { get; set; }
        [Display(Name = "ICAO Code")]
        public string? ICAOCode { get; set; }
        public string Name { get; set; }
        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }  
        public string? Description { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; }

        public Airport()
        {
            Destinations = new HashSet<Destination>();
        }
    }   
}
