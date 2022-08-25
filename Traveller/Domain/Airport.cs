using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Airport
    {
        public int AirportID { get; set; }
        [Display(Name = "Airport Type")]
        public AirportType AirportType { get; set; }

        [Display(Name = "IATA Code")]
        public string IATACode { get; set; }

        [Display(Name = "ICAO Code")]
        public string? ICAOCode { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public virtual ICollection<Destination>? ServingDestinations { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public Airport() {

            this.ServingDestinations = new HashSet<Destination>();
        }
    }

    public class AirportType
    {
        public int AirportTypeID { get; set; }
        public char? Code { get; set; }
        public string? Description { get; set; }


    }
}
