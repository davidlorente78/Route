using Domain.Generic;

namespace Domain.Transport.Aviation
{
    public class AirlineType : EntityType
    {
        public int AirlineTypeID { get; set; }
        public ICollection<Airline> Airlines { get; set; } = new List<Airline>();

    }
}
