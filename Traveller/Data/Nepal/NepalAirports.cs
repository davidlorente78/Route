using Data.EntityTypes;
using Domain.Transport.Aviation;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nepal
{
    public static class NepalAirports
    {
        //Los 9 aeropuertos más grandes en Nepal
        //IATA    Nombre Paraje  Aerolíneas Destinos
        //KTM Tribhuvan International Airport Kathmandu	27	32
        public static Airport KTM = new Airport
        {
            Name = "Tribhuvan International Airport",
            Destinations = new List<Destination> { NepalDestinations.Kathmandu },
            IATACode = "KTM",
            AirportType = AirportTypes.International
        };

        //BHR Bharatpur Airport Bharatpur	1	1
        //BWA Gautam Buddha Airport   Bhairawa	1	1
        //BDP Bhadrapur Airport Bhadrapur	1	1
        //JKR Janakpur Airport Janakpur	1	1
        //KEP Nepalgunj Airport Nepalgunj	1	1
        //PKR Pokhara Airport Pokhara	1	1
        //TMI Tumling Tar Airport Tumling Tar	1	1
        //BIR Biratnagar Airport Biratnagar	1	1

        public static Airport BHR = new Airport
        {
            Name = "Bharatpur Airport",
            Destinations = new List<Destination> { NepalDestinations.Bharatpur },
            IATACode = "BHR",
            AirportType = AirportTypes.Domestic,
            Description = "Bharatpur Airport, situated in the city of Bharatpur, Nepal, is a key domestic airport connecting travelers to the Chitwan District. The airport serves as a convenient gateway to the renowned Chitwan National Park, offering access to diverse wildlife and natural wonders. Explore the lush landscapes, embark on thrilling safaris, and immerse yourself in the vibrant culture of Bharatpur. Whether you're an adventure seeker or nature enthusiast, Bharatpur Airport provides a starting point for unforgettable experiences in the heart of Nepal."
        };

        public static Airport BWA = new Airport
        {
            Name = "Gautam Buddha Airport",
            Destinations = new List<Destination> { NepalDestinations.Bhairawa },
            IATACode = "BWA",
            AirportType = AirportTypes.Domestic,
            Description = "Gautam Buddha Airport, located in Bhairawa, Nepal, plays a crucial role in connecting travelers to the sacred Lumbini, the birthplace of Lord Buddha. The airport offers a gateway to the spiritual and historical significance of Lumbini, with its ancient monuments, temples, and serene gardens. Explore the birthplace of Buddhism, visit the sacred Maya Devi Temple, and experience the tranquility of Lumbini's pilgrimage sites. Gautam Buddha Airport invites you to embark on a journey of spiritual discovery and cultural exploration in the cultural heartland of Nepal."
        };

        public static Airport BDP = new Airport
        {
            Name = "Bhadrapur Airport",
            Destinations = new List<Destination> { NepalDestinations.Bhadrapur },
            IATACode = "BDP",
            AirportType = AirportTypes.Domestic,
            Description = "Bhadrapur Airport, located in the town of Bhadrapur, Nepal, serves as a vital air link to the eastern regions of the country. The airport provides access to the scenic landscapes and cultural attractions of eastern Nepal. Explore the charming town of Bhadrapur, surrounded by lush tea gardens and picturesque views of the Himalayas. Discover the unique blend of tradition and natural beauty that defines this region. Whether you're seeking cultural experiences or scenic adventures, Bhadrapur Airport offers a gateway to the diverse wonders of eastern Nepal."
        };

        public static Airport JKR = new Airport
        {
            Name = "Janakpur Airport",
            Destinations = new List<Destination> { NepalDestinations.Janakpur },
            IATACode = "JKR",
            AirportType = AirportTypes.Domestic,
            Description = "Janakpur Airport, located in the city of Janakpur, Nepal, serves as a vital domestic airport connecting travelers to the historic and religious sites in the region. Explore the cultural heritage of Janakpur, known for its temples and shrines, including the revered Janaki Mandir. The airport offers convenient access to the spiritual and historical significance of Janakpur, making it an ideal starting point for pilgrimages and cultural exploration in this sacred city."
        };

        public static Airport KEP = new Airport
        {
            Name = "Nepalgunj Airport",
            Destinations = new List<Destination> { NepalDestinations.Nepalgunj },
            IATACode = "KEP",
            AirportType = AirportTypes.Domestic,
            Description = "Nepalgunj Airport, situated in Nepalgunj, Nepal, is a key domestic airport providing access to the western regions of the country. The airport serves as a gateway to the diverse landscapes and cultural attractions of western Nepal. Explore the town of Nepalgunj, known for its cultural diversity and vibrant markets. Whether you're interested in exploring national parks, wildlife sanctuaries, or historical sites, Nepalgunj Airport sets the stage for memorable experiences in the western part of Nepal."
        };

        public static Airport PKR = new Airport
        {
            Name = "Pokhara Airport",
            Destinations = new List<Destination> { NepalDestinations.Pokhara },
            IATACode = "PKR",
            AirportType = AirportTypes.Domestic,
            Description = "Pokhara Airport, located in the scenic city of Pokhara, Nepal, is a prominent domestic airport providing access to the picturesque landscapes of the Annapurna region. The airport serves as a gateway to the adventure capital of Nepal, offering breathtaking views of the Himalayas, serene lakes, and lush greenery. Explore Pokhara's vibrant lakeside, embark on treks to iconic viewpoints, and experience the beauty of Nepal's second-largest city. Pokhara Airport invites you to discover the natural wonders and adventure opportunities that await in the heart of the Annapurna region."
        };

        public static Airport TMI = new Airport
        {
            Name = "Tumling Tar Airport",
            Destinations = new List<Destination> { NepalDestinations.TumlingTar},
            IATACode = "TMI",
            AirportType = AirportTypes.Domestic,
            Description = "Tumling Tar Airport, located in Tumling Tar, Nepal, serves as a domestic airport providing access to the eastern regions of the country. The airport offers a gateway to the diverse landscapes and cultural attractions of eastern Nepal. Explore the unique charm of Tumling Tar, surrounded by natural beauty and cultural richness. Whether you're interested in exploring historical sites, natural wonders, or embarking on treks, Tumling Tar Airport provides a convenient starting point for your journey into the eastern part of Nepal."
        };

        public static Airport BIR = new Airport
        {
            Name = "Biratnagar Airport",
            Destinations = new List<Destination> { NepalDestinations.Biratnagar },
            IATACode = "BIR",
            AirportType = AirportTypes.Domestic,
            Description = "Biratnagar Airport, situated in the city of Biratnagar, Nepal, is a major domestic airport connecting travelers to the eastern regions of the country. The airport provides access to the industrial and commercial hub of eastern Nepal. Explore the bustling city of Biratnagar, known for its trade, industries, and cultural diversity. Whether you're on a business trip or exploring the cultural attractions of the region, Biratnagar Airport offers a convenient and well-connected gateway to eastern Nepal."
        };

        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                 NepalAirports.KTM,
                NepalAirports.BHR,
                NepalAirports.BWA,
                NepalAirports.BDP,
                NepalAirports.JKR,
                NepalAirports.KEP,
                NepalAirports.PKR,
                NepalAirports.TMI,
                NepalAirports.BIR
            };
        }
    }
}
