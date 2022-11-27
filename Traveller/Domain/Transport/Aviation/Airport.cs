using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Aviation
{
    public class Airport
    {
        public int AirportID { get; set; }

        [Required]
        [Display(Name = "Airport Type")]
        public AirportType AirportType { get; set; }

        [Display(Name = "IATA Code")]
        public string IATACode { get; set; }

        [Display(Name = "ICAO Code")]
        public string? ICAOCode { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; }
        public int AirportCountryID { get; set; }
        public virtual Country AirportCountry { get; set; }

        public Airport()
        {
            Destinations = new HashSet<Destination>();
        }
    }

   
}
