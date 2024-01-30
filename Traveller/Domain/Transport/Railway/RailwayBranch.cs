using System.ComponentModel.DataAnnotations;
using Domain.Generic;

namespace Domain.Transport.Railway
{
    public class RailwayBranch : Entity<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Main Branch")]
        public bool MainBranch { get; set; }
        public int RailwayLineID { get; set; }
        public RailwayLine RailwayLine { get; set; }
        public ICollection<RailwayStation> Stations { get; set; }
    }
}
