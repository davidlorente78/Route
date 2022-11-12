using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Railway
{
    //Test Here Composition
    public class RailwayStation
    {
        public int RailwayStationID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public char Type { get; set; }  // T B
        public string? Remarks { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; } = new List<Destination>();
        public virtual ICollection<Facility>? Facilities { get; set; } = new List<Facility>();

        //public ICollection<Destination>? MajorLandmarks { get; set; }
        //public ICollection<Destination>? InterchangeStations { get; set; }

    }

}
