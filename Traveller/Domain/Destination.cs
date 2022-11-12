using Domain;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public string? Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Photo")]
        public string? Picture { get; set; }

        [Display(Name = "Destination Type")]
        public List<DestinationType> DestinationTypes { get; set; } = new List<DestinationType>();
      
        public ICollection<Airport> Airports { get; set; } = new List<Airport>();

        public ICollection<RailwayStation> Stations { get; set; } = new List<RailwayStation>();

        public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    }

 
}
