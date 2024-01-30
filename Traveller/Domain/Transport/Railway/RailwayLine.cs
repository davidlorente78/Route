using System.ComponentModel;
using Traveller.Domain;
using Domain.Generic;

namespace Domain.Transport.Railway
{

    public class RailwayLine : Entity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }

        [DisplayName("Line Type")]
        public char LineType { get; set; }
        public ICollection<RailwayBranch>? Branches { get; set; }

        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
