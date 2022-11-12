using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain.Transport.Railway
{    //Test Here Composition

    public class RailwayLine
    {
        public int RailwayLineID { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }

        [DisplayName("Line Type")]
        public char LineType { get; set; }
        public ICollection<RailwayBranch>? Branches { get; set; }

        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
