using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Railway
{
    public class RailwayBranch
    {
        public int RailwayBranchID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Main Branch")]
        public bool MainBranch { get; set; }
        public int RailwayLineID { get; set; }
        public RailwayLine RailwayLine { get; set; }
        public ICollection<RailwayStation> Stations { get; set; }


    }



}
