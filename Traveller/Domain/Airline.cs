using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Airline
    {
        public int Id { get; set; }
        public string? IATACode { get; set; }       
        public string Name { get; set; }
        public string? LocalName { get; set; }
        public int? MainAirportID { get; set; }
        public virtual Airport? MainAirport { get; set; }
        public List<Airport>? Airports { get; set; }

        [Required]
        [StringLength(5000)]
        public string Description { get; set; }

        [Display(Name = "Route Map")]
        public string Picture { get; set; }

        [Display(Name = "Web Site")]
        public string? Url { get; set; }
       
        public Airline() {

           
        }
    }

    public class AirlineType
    {
        public int AirlineTypeID { get; set; }
        public char? Code { get; set; }
        public string? Description { get; set; }


    }
}
