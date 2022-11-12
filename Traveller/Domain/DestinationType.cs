using Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Domain
{
    public class DestinationType : EntityType
    {
        public int DestinationTypeID { get; set; }
        public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
    }
}
