using Domain.Transport.Aviation;
using StaticData.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Malaysia
{
    public static class MalaysiaAirports
    {

        public static Airport KUL = new Airport
        {
            Name = "Kuala Lumpur International Airport",            
            Destinations = new List<Destination> { MalaysiaDestinations.KualaLumpur },
            IATACode = "KUL",          
            AirportType = AirportTypes.International
        };
        public static Airport BKI = new Airport
        {
            Name = "Kota Kinabalu International Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.KotaKinabalu },
            IATACode = "BKI",
            AirportType = AirportTypes.International
        };
        public static Airport PEN = new Airport
        {
            Name = "Penang International Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.Penang },
            IATACode = "PEN",
            AirportType = AirportTypes.International
        };

        public static Airport LGK = new Airport
        {
            Name = "Langkawi International Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.Langkawi },
            IATACode = "LGK",
            AirportType = AirportTypes.International
        };

        public static Airport KCH = new Airport
        {
            Name = "Kuching International Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.Kuching },
            IATACode = "KCH",
            AirportType = AirportTypes.International
        };

        public static Airport JHB = new Airport
        {
            Name = "Senai International Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.JohorBahru },
            IATACode = "JHB",
            AirportType = AirportTypes.International
        };

        public static Airport MYY = new Airport
        {
            Name = "Miri Airport",
            Destinations = new List<Destination> { },
            IATACode = "MYY",
            AirportType = AirportTypes.Domestic
        };

        public static Airport AOR = new Airport
        {
            Name = "Sultan Abdul Halim Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.AlorSatar },
            IATACode = "AOR",
            AirportType = AirportTypes.Domestic
        };

        public static Airport KBR = new Airport
        {
            Name = "Sultan Ismail Petra",
            Destinations = new List<Destination> { MalaysiaDestinations.KotaBaharu },
            IATACode = "KBR",
            AirportType = AirportTypes.Domestic
        };

        public static Airport TGG = new Airport
        {
            Name = "Sultan Mahmud Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.KualaTerengganu },
            IATACode = "TGG",
            AirportType = AirportTypes.Domestic
        };

        public static Airport SZB = new Airport
        {
            Name = "Sultan Abdul Aziz Shah",
            Destinations = new List<Destination> { MalaysiaDestinations.Subang },
            IATACode = "SZB",
            AirportType = AirportTypes.Domestic
        };


        public static Airport SBW = new Airport
        {
            Name = "Sibu Airport",
            LocalName = "Lapangan Terbang Sibu",
            Destinations = new List<Destination> { },
            IATACode = "SBW",
            ICAOCode= "WBGS",
            AirportType = AirportTypes.Domestic
        };

        //BTU Bintulu Airport Bintulu 2	5
        //LBU Labuan Airport Labuan  2	3
        //SDK Sandakan Airport Sandakan    2	4
        //TWU Tawau Airport Tawau   2	5
        //MZV Mulu Airport Mulu    2	4
        //KUA Kuantan Airport Kuantan 2	3
        public static Airport IPH = new Airport
        {
            Name = "Sultan Azlan Shah Airport",
            Destinations = new List<Destination> { MalaysiaDestinations.Ipoh },
            IATACode = "IPH",
            AirportType = AirportTypes.Domestic
        };
        //LGL Long Lellang Airport    Long Datih  1	2
        //ODN Long Seridan Airport    Long Seridan    1	2
        //LMN Limbang Airport Limbang 1	1
        //MKM Mukah Airport Mukah   1	2
        //MUR Marudi Airport Marudi  1	6
        //BKM Bakalalan Airport Bakalalan   1	1
        //LWY Lawas Airport Lawas   1	3
        //BBN Bario Airport Bario   1	2
        //LDU Lahad Datu Airport  Lahad Datu  1	1
        //KUD Kudat Airport Kudat   1	2
        //LBP Long Banga Airport  Long Banga  1	1


        public static ICollection<Airport> GetAll()
            { 


            return new List<Airport>
            {
                BKI,PEN,LGK,KCH,JHB,MYY,AOR,KBR,TGG,SZB,SBW,KUL,IPH
            };

        }
    }
}
