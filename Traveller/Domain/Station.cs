using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain
{

    public class Station
    {
        public int StationID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public char Type { get; set; }  // T B
        public string? Remarks { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; }
        //public ICollection<Destination>? MajorLandmarks { get; set; }
        //public ICollection<Destination>? InterchangeStations { get; set; }

    }
    
}
