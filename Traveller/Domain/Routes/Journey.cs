using Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain.Routes
{
    public class Journey : Entity
    {
        public Itinerary PlannedItinerary { get; set; } // Se indica aqui el itinerary que se esta siguiendo
        public Destination CurrentCountry { get; set; }
        public Destination CurrentDestination { get; set; }
        public Domain.Ranges.Month CurrentMonth { get; set; }
        public DateTime Today { get; set; }
        public List<Nomad> Nomads { get; set; }
    }
}
