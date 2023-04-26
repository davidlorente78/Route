using Domain.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Transport.Aviation
{
    public class Airline : Entity
    {
        public string? IATACode { get; set; }
        public string Name { get; set; }
        public string? LocalName { get; set; }
        public int? MainAirportID { get; set; }
        public virtual Airport? MainAirport { get; set; }
        public List<Airport>? Airports { get; set; }
        public virtual AirlineType? AirlineType { get; set; }
        public int AirlineTypeID { get; set; }

        [Required]
        [StringLength(5000)]
        public string Description { get; set; }

        [Display(Name = "Route Map")]
        public string Picture { get; set; }

        [Display(Name = "Web Site")]
        public string? Url { get; set; }

        public Airline()
        {

        }
    }
}
