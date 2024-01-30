using Domain.Generic;
using Traveller.Domain;

namespace Domain.Itineraries
{
    public class Journey : Entity<int>
    {
        public Itinerary PlannedItinerary { get; set; } // Se indica aqui el itinerary que se esta siguiendo
        public Destination CurrentCountry { get; set; }
        public Destination CurrentDestination { get; set; }
        public Domain.Ranges.Month CurrentMonth { get; set; }
        public DateTime Today { get; set; }
        public List<Nomad> Nomads { get; set; }
    }
}
