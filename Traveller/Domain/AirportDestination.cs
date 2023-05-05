using Domain.Transport.Aviation;
using Traveller.Domain;

namespace Domain
{
    public class AirportDestination
    {
        public int AirportId { get; set; }
        public Airport Airport { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
