using Traveller.Domain;

namespace Domain.Transport.Railway.Train
{
    //TODO
    public class TrainService
    {
        //Chiang Mai Train Services
        //Special Express 7/8 Krung Thep Aphiwat–Chiang Mai–Krung Thep Aphiwat
        //Special Express "Uttarawithi" 9/10 Krung Thep Aphiwat–Chiang Mai–Krung Thep Aphiwat
        //Special Express 13/14 Krung Thep Aphiwat–Chiang Mai–Krung Thep Aphiwat
        //Express 51/52 Krung Thep Aphiwat–Chiang Mai–Krung Thep Aphiwat
        //Rapid 109/102 Krung Thep Aphiwat–Chiang Mai–Krung Thep Aphiwat
        //Local 407/408 Nakhon Sawan–Chiang Mai–Nakhon Sawan


        //Saraphi railway station
        //Local 407/408 Nakhon Sawan–Chiang Mai–Nakhon Sawan



        public RailwayStation RailwayStation { get; set; }
        public int RailwayStationId { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }  // T B
        public string? Remarks { get; set; }
        public virtual ICollection<Destination>? Destinations { get; set; } = new List<Destination>();
    }
}
