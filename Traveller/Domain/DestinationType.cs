using Domain.Generic;

namespace Traveller.Domain
{
    public class DestinationType : EntityType
    {
        public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
    }
}
