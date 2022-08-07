using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace StaticData.Malaysia
{
    public static class MalaysiaAirports
    {

        //IATA Nombre  Paraje Aerolíneas  Destinos
        //KUL Kuala Lumpur International Airport  Kuala Lumpur    63	112
        //BKI Kota Kinabalu International Airport Kota Kinabalu	18	30
        //PEN Penang International Airport    Penang	17	20
        //LGK Langkawi International Airport  Langkawi	8	5
        //KCH Kuching International Airport   Kuching	7	14
        //JHB Senai International Airport Johor Bahru 6	12
        //MYY Miri Airport Miri    4	20
        //AOR Sultan Abdul Halim Airport Alor Satar	4	2
        //KBR Sultan Ismail Petra Airport Kota Baharu	4	7
        //TGG Sultan Mahmud Airport   Kuala Terengganu    4	4
        //SZB Sultan Abdul Aziz Shah International Airport Subang  4	12
        //SBW Sibu Airport Sibu    3	6

        public static Airport SBW = new Airport
        {
            Name = "Sibu Airport",
            LocalName = "Lapangan Terbang Sibu",
            ServingDestinations = new List<Destination> { },
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
        //IPH Sultan Azlan Shah Airport Ipoh    2	1
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
                SBW
            };

        }
    }
}
