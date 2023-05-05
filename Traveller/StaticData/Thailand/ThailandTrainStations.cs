using Domain.Transport.Railway;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Thailand
{
    public class ThailandTrainStations
    {
        #region Southern Line

        public static RailwayStation BangkokHuaLamphong = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Bangkok },
            Name = "Bangkok Hua Lamphong",
            Remarks = ""
        };
        //Bang Sue Grand Station - Main station and freight terminal with main diesel locomotive depot and refueling facilityBang Bamru Station- Suburban Station, all trains must stop here.First station after crossing the Rama 6 Bridge from Bang Sue.
        //Taling Chan Junction- Junction for Southern Main Line(Bang Sue-Taling Chan Link) and Thonburi Branch.
        //Thon Buri Station - Former terminus of Southern Line, however some southern trains remain to start the journey here.

        public static RailwayStation ThonBuri = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thon Buri",
            Remarks = "Former terminus of Southern Line, however some southern trains remain to start the journey here."
        };

        //Salaya Station- Suburban Station, for Phutthamonthon District and Mahidol University (Salaya Campus)
        //Nakhon Pathom Station - Main southern suburban station. Main Nakhon Pathom station.
        //Nong Pladuk Junction - Junction for Namtok Branch Line and Suphan Buri Branch Line.
        //Ban Pong Station - Interchange to Kanchanaburi for those who did not travel along Nam Tok branch line
        //Ratchaburi Station - Terminal for southern suburban service, also Ratchaburi main station.

        public static RailwayStation Ratchaburi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ratchaburi",
            Remarks = "Terminal for southern suburban service, also Ratchaburi main station."
        };

        //Phetchaburi Station - Phetchaburi main station.
        public static RailwayStation Phetchaburi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phetchaburi",
            Remarks = "Phetchaburi main station."
        };
        //Hua Hin Station - Provincial Station for Hua Hin in Prachuap Khiri Khan with crew changing station.
        public static RailwayStation HuaHin = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hua Hin",
            Remarks = "rovincial Station for Hua Hin in Prachuap Khiri Khan with crew changing station."
        };
        //Wang Phong Station- One of the stations in Pran Buri. Also for the nearby Thanarat Military Camp.More trains stop here for Pran Buri than Pran Buri Station itself.
        //Pran Buri Station- Smaller station for Pran Buri, with a well-established Saturday Night Market opposite the station.
        //Prachuap Khiri Khan Station - Prachuap Khiri Khan main station.
        public static RailwayStation PrachuapKhiriKhan = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Prachuap Khiri Khan",
            Remarks = "Prachuap Khiri Khan main station."
        };
        //Bang Saphan Yai Station - Regional town station.All trains going further south must stop here.

        //Chumphon Station - Main Chumphon station, locomotive depot with refuelling facility
        public static RailwayStation Chumphon = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chumphon",
            Remarks = "Main Chumphon station, locomotive depot with refuelling facility."
        };


        public static RailwayStation LangSuan = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lang Suan ",
            Remarks = "Provincial Station in Chumphon. Furthest extent of southern services from Thonburi."
        };
        //Ban Thung Pho Junction - Southern container yard, for Khiri Rat Nikhom Branch.



        public static RailwayStation KhiriRatNikhom = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Phuket, ThailandDestinations.PhangNga },
            Name = "Khiri Rat Nikhom Station",
            Remarks = "Terminus for the Khiri Rat Nikhom Branch and the railway to Phang Nga and Tanun (Phuket)."
        };

        //Surat Thani Station - Crew changing station and Surat Thani main station.
        public static RailwayStation SuratThani = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Surat Thani",
            Remarks = "Surat Thani is a busy train station with connecting bus and ferry services to and from Koh Samui and Koh Phangan. A large number of passengers also pass through Surat Thani train station on the way to destinations on the Andaman coast, such as Krabi and Phuket, which are not connected to Thailand’s railway network. There are connecting bus and minivan services from Surat Thani to Phuket Town and Krabi Town."
        };

        public static RailwayStation ThungSongJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thung Song",
            Remarks = "Locomotive depot, refuelling facility and junction for Kantang Branch."
        };

        public static RailwayStation Trang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Trang },
            Name = "Trang",
            Remarks = "Main Trang station."
        };


        public static RailwayStation Kantang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Kantang",
            Remarks = "Terminus of Kantang Branch."
        };

        public static RailwayStation KhaoChumThongJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khao Chum Thong Junction",
            Remarks = "Junction for Nakhon Si Thammarat Branch."
        };

        public static RailwayStation NakhonSiThammarat = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Si Thammarat",
            Remarks = ""
        };

        public static RailwayStation Phatthalung = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phatthalung",
            Remarks = "Phatthalung main station, crew changing station"
        };

        public static RailwayStation HatYaiJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Songkhla },
            Name = "Hat Yai Junction",
            Remarks = "Main junction for Malaysia and Singapore and Main Line of Southern Line, Locomotive Depot and refueling facility. Main Songkhla Station."
        };

        public static RailwayStation PadangBesar = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { MalaysiaDestinations.PadangPesar, ThailandDestinations.PadangPesar },
            Name = "Padang Besar",
            Remarks = "The Padang Besar railway station has Malaysia's only co-located or juxtaposed customs, immigration and quarantine facility for both Malaysia and Thailand and rail passengers are processed for exiting Malaysia and entering Thailand (or vice versa if traveling the other direction) in the station. The Padang Besar station in Thailand only serves as a domestic station."
        };

        //Branch

        public static RailwayStation Pattani = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Pattani",
            Remarks = "Formerly Khok Pho station, Pattani main station."
        };

        public static RailwayStation Yala = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Yala",
            Remarks = "Main Yala station, crew changing station."
        };

        public static RailwayStation TanyongMat = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Tanyong Mat",
            Remarks = "for Ra Ngae district and Narathiwat."
        };

        public static RailwayStation SungaiKolok = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.SungaiKolok, MalaysiaDestinations.RantanPanjang },
            Name = "Su-ngai",
            Remarks = "Terminus of Southern Line. Used to be an international station until the termination of cross border services."
        };

        #endregion

        #region NorthernLine_Sawankhalok

        public static RailwayStation BanDaraJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Dara Junction",
            LocalName = "ชุมทางบ้านดารา",
            Remarks = "The terminal of Sawankhalok Line"
        };


        public static RailwayStation KhlongMaphlap = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khlong Maphlap",
            LocalName = "คลองมะพลับ",
            Remarks = ""
        };

        public static RailwayStation SawanKhalok = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sawan Khalok",
            LocalName = "สวรรคโลก",
            Remarks = "Terminus of Sawankhalok Branch. Station for Sukhothai Province and travel to Sukhothai and Si Satchanalai Historical Parks."
        };

        #endregion

        #region Northern Line Main Stations



        public static RailwayStation Rangsit = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Rangsit",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation Ayutthaya = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ayutthaya",
            LocalName = "อยุธยา",
            Remarks = "https://en.wikipedia.org/wiki/Ayutthaya_railway_station" +
            "Ayutthaya Railway Station is located on the East side of the river 3.1 km walking distance from Bang Lan Night Market in the centre of Ayutthaya. Built in 1921 the main station building and the ticket hall has been superbly preserved and this is one of Thailand’s best train stations. The station is a busy transport hub with all trains travelling on the Northern Line and the North Eastern Line stopping here."
        };

        public static RailwayStation BanPhachiJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pachi Junction",
            Remarks = "Start for NorthEast Line"
        };

        public static RailwayStation LopBuri = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lop Buri",
            LocalName = "ลพบุรี",
            Remarks = "The end of northern Bangkok suburban service; a military town with much history."
        };

        public static RailwayStation BanTakhli = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Takhli",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation NakhonSawan = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Sawan",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation TaphanHin = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Taphan Hin",
            LocalName = "",
            Remarks = ""
        };
        public static RailwayStation Phichit = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phichit",
            LocalName = "",
            Remarks = "Phichit Main Station"
        };

        public static RailwayStation Phitsanulok = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Sukhothai, ThailandDestinations.Phitsanulok },
            Name = "Phitsanulok",
            LocalName = "พิษณุโลก",
            Remarks = "Phitsanulok Main station, town with the famous Phra Phuttha Chinnarat"
        };

        public static RailwayStation Uttaradit = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Uttaradit",
            LocalName = "",
            Remarks = "Main station, Uttaradit Province."
        };

        public static RailwayStation SilaAt = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sila At",
            LocalName = "",
            Remarks = "Depot on the Northern Line. Refueling station and up trains will be cut at this station"
        };

        public static RailwayStation DenChai = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Den Chai",
            LocalName = "",
            Remarks = "The dropping point for Phrae with a proposal for a junction for Den Chai – Chiang Rai route"
        };

        public static RailwayStation BanPin = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pin",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation NakhonLampang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Lampang",
            LocalName = "",
            Remarks = " Depot on the Northern Line. Train will be cut further if going north to Chiang Mai."
        };

        public static RailwayStation HangChat = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hang Chat",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation Lamphun = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lamphun",
            LocalName = "",
            Remarks = "Main station for Lamphun Province"
        };

        public static RailwayStation ChiangMai = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.ChiangMai },
            Name = "Chiang Mai",
            LocalName = "สถานีเชียงใหม่ (ชม.)",
            Remarks = "Northern terminus. Chiang Mai station (SRT Code: CGM) (Thai: สถานีเชียงใหม่ (ชม.)) is a 1st class station and the main railway station in Chiang Mai Province. This station is on the east side of the Ping River in the city of Chiang Mai. There are 10 daily trains, not including Eastern and Oriental Express trains servicing this station. There are also four to six special trains for New Year, Songkran and other special festivals. In the 2004 census, Chiang Mai station served nearly 800,000 passengers."
        };

        #endregion

        #region NorthEast Line Main Stations UbonRatchathani Branch

        //BanPachi
        public static RailwayStation BanPachi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pachi",
            LocalName = "",
            Remarks = ""
        };

        //Thanon Chira Junction
        public static RailwayStation ThanonChiraJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thanon Chira Junction",
            LocalName = "",
            Remarks = ""
        };

        //Surin
        public static RailwayStation Surin = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Surin",
            LocalName = "",
            Remarks = ""
        };

        //Sisaket
        public static RailwayStation Sisaket = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sisaket",
            LocalName = "",
            Remarks = ""
        };


        //UbonRatchathani
        public static RailwayStation UbonRatchathani = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ubon Ratchathani",
            LocalName = "",
            Remarks = ""
        };
        #endregion

        #region NorthEast Line Main Stations UbonRatchathani Nong Khai

        //Kaeng Khoi Juction
        public static RailwayStation KaengKhoiJuction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Kaeng Khoi Juction",
            LocalName = "",
            Remarks = ""
        };

        //Bua Yai Junction

        public static RailwayStation BuaYaiJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Bua Yai Junction",
            LocalName = "",
            Remarks = ""
        };

        //Khon Kaen

        public static RailwayStation KhonKaen = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khon Kaen",
            LocalName = "",
            Remarks = ""
        };
        //Udon Thani

        public static RailwayStation UdonThani = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Udon Thani",
            LocalName = "",
            Remarks = ""
        };


        //Nong Khai
        public static RailwayStation NongKhai = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.NongKhai, LaosDestinations.NongKhiang },
            Name = "Nong Khai",
            LocalName = "",
            Remarks = ""
        };
        #endregion

        #region NorthEast Line Main Stations Branch

        //Thanon Chira Junction
        //Bua Yai Junction

        #endregion

        public static RailwayStation Pattaya = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Pattaya",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation Aranyaprathet = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Aranyaprathet },
            Name = "Aranyaprathet",
            LocalName = "อรัญประเทศ",
            Remarks = "Aranyaprathet railway station is a railway station located in Aranyaprathet Subdistrict, Aranyaprathet District, Sa Kaeo, Thailand. The station is a class 1 railway station located 254.5 km (158.1 mi) from Bangkok Railway Station. Aranyaprathet Railway Station opened in 8 November 1926 as part of the Eastern Line Kabin Buri–Aranyaprathet section.",
        };

        #region Eastern Line

        public static RailwayStation ChachengsaoJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chachengsao Junction",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation Chonburi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chonburi",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation SriRachaJunction = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sri Racha Junction",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation BanPluTaLuang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Plu Ta Luang",
            LocalName = "",
            Remarks = ""
        };

        public static RailwayStation MarpTaPut = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Rayong },
            Name = "MarpTaPut",
            LocalName = "",
            Remarks = ""
        };

        #endregion
    }
}
