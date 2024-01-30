using System.ComponentModel.DataAnnotations;
using Traveller.Domain;
using Domain.Generic;

namespace Domain.Transport.Railway
{
    public class RailwayStation : Entity<int>
    {
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public char Type { get; set; }  // T B
        public string? Remarks { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; } = new List<Destination>();
    }
}
