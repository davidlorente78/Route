using Domain;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string? Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Destination Type")]
        public List<DestinationType>? DestinationTypes { get; set; } = new List<DestinationType>();
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public List<Airport>? Airports { get; set; }

        public List<Station>? Stations { get; set; }
    }

    public class DestinationType
    {
        public int DestinationTypeID { get; set; }
        public char? Code { get; set; }      
        public string? Description { get; set; }
        public ICollection<Destination> Destinations { get; set; }

    }
}
