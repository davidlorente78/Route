using Domain;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Thailand
{
    public class ThailandTrainStations
    {

        #region Southern Line

        public static Station BangkokHuaLamphong = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Bangkok},
            Name = "Bangkok Hua Lamphong",
            Remarks = ""
        };
        //Bang Sue Grand Station - Main station and freight terminal with main diesel locomotive depot and refueling facilityBang Bamru Station- Suburban Station, all trains must stop here.First station after crossing the Rama 6 Bridge from Bang Sue.
        //Taling Chan Junction- Junction for Southern Main Line(Bang Sue-Taling Chan Link) and Thonburi Branch.
        //Thon Buri Station - Former terminus of Southern Line, however some southern trains remain to start the journey here.

        public static Station ThonBuri = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {  },
            Name = "Thon Buri",
            Remarks = "Former terminus of Southern Line, however some southern trains remain to start the journey here."
        };

        //Salaya Station- Suburban Station, for Phutthamonthon District and Mahidol University (Salaya Campus)
        //Nakhon Pathom Station - Main southern suburban station. Main Nakhon Pathom station.
        //Nong Pladuk Junction - Junction for Namtok Branch Line and Suphan Buri Branch Line.
        //Ban Pong Station - Interchange to Kanchanaburi for those who did not travel along Nam Tok branch line
        //Ratchaburi Station - Terminal for southern suburban service, also Ratchaburi main station.

        public static Station Ratchaburi = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ratchaburi",
            Remarks = "Terminal for southern suburban service, also Ratchaburi main station."
        };

        //Phetchaburi Station - Phetchaburi main station.
        public static Station Phetchaburi = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phetchaburi",
            Remarks = ""
        };
        //Hua Hin Station - Provincial Station for Hua Hin in Prachuap Khiri Khan with crew changing station.
        public static Station HuaHin = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hua Hin",
            Remarks = "rovincial Station for Hua Hin in Prachuap Khiri Khan with crew changing station."
        };
        //Wang Phong Station- One of the stations in Pran Buri. Also for the nearby Thanarat Military Camp.More trains stop here for Pran Buri than Pran Buri Station itself.
        //Pran Buri Station- Smaller station for Pran Buri, with a well-established Saturday Night Market opposite the station.
        //Prachuap Khiri Khan Station - Prachuap Khiri Khan main station.
        public static Station PrachuapKhiriKhan = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Prachuap Khiri Khan",
            Remarks = "Prachuap Khiri Khan main station."
        };
        //Bang Saphan Yai Station - Regional town station.All trains going further south must stop here.

        //Chumphon Station - Main Chumphon station, locomotive depot with refuelling facility
        public static Station Chumphon = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chumphon",
            Remarks = "Main Chumphon station, locomotive depot with refuelling facility."
        };


        public static Station LangSuan = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {  },
            Name = "Lang Suan ",
            Remarks = "."
        };
        //Ban Thung Pho Junction - Southern container yard, for Khiri Rat Nikhom Branch.



        public static Station KhiriRatNikhom  = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Phuket, ThailandDestinations.PhangNga},
            Name = "Khiri Rat Nikhom Station",
            Remarks = "Terminus for the Khiri Rat Nikhom Branch and the railway to Phang Nga and Tanun (Phuket)."
        };

        //Surat Thani Station - Crew changing station and Surat Thani main station.
        public static Station SuratThani = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Surat Thani",
            Remarks = "Surat Thani is a busy train station with connecting bus and ferry services to and from Koh Samui and Koh Phangan. A large number of passengers also pass through Surat Thani train station on the way to destinations on the Andaman coast, such as Krabi and Phuket, which are not connected to Thailand’s railway network. There are connecting bus and minivan services from Surat Thani to Phuket Town and Krabi Town."
        };

        
        //Thung Song Junction - Locomotive depot, refuelling facility and junction for Kantang Branch.
        public static Station ThungSongJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thung Song",
            Remarks = "Locomotive depot, refuelling facility and junction for Kantang Branch."
        };

        //Trang Station - Trang main station.

        public static Station Trang = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Trang },
            Name = "Trang",
            Remarks = "Main Trang station."
        };

        //Kantang Station - Terminus of Kantang Branch.

        public static Station Kantang = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Kantang",
            Remarks = "Terminus of Kantang Branch."
        };

      
        //Khao Chum Thong Junction - Junction for Nakhon Si Thammarat Branch.

        public static Station KhaoChumThongJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khao Chum Thong Junction",
            Remarks = ""
        };
        //Nakhon Si Thammarat Station - Terminus of Nakhon Si Thammarat Branch. Nakhon Si Thammarat main station.

        public static Station NakhonSiThammarat = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Si Thammarat",
            Remarks = ""
        };
        //Phatthalung Station - Phatthalung main station, crew changing station

        public static Station Phatthalung = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phatthalung",
            Remarks = ""
        };

        //Hat Yai Junction - Main junction for Malaysia[23] and Singapore and Main Line of Southern Line, Locomotive Depot and refueling facility.Main Songkhla Station.
        public static Station HatYaiJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Songkhla },
            Name = "Hat Yai Junction",
            Remarks = "Main junction for Malaysia and Singapore and Main Line of Southern Line, Locomotive Depot and refueling facility. Main Songkhla Station."
        };

        //Padang Besar Station - International KTM station in Malaysia.Trains continue to Butterworth (Penang) and further.
        public static Station PadangBesar = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { MalaysiaDestinations.PadangPesar, ThailandDestinations.PadangPesar },
            Name = "Padang Besar",
            Remarks = "International KTM station in Malaysia. Trains continue to Butterworth (Penang) and further."
        };

        //Branch
        //Pattani Station - formerly Khok Pho station, Pattani main station.

        public static Station Pattani = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Pattani",
            Remarks = "formerly Khok Pho station, Pattani main station."
        };

        //Yala Station - Main Yala station, crew changing station

        public static Station Yala = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Yala",
            Remarks = "Main Yala station, crew changing station."
        };

        //Tanyong Mat Station - for Ra Ngae district and Narathiwat.

        public static Station TanyongMat = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {  },
            Name = "Tanyong Mat",
            Remarks = "for Ra Ngae district and Narathiwat."
        };

        public static Station SungaiKolok = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.SungaiKolok, MalaysiaDestinations.RantanPanjang },
            Name = "Su-ngai",
            Remarks = "Terminus of Southern Line. Used to be an international station until the termination of cross border services."
        };

        #endregion

        #region NorthernLine_Sawankhalok

        public static Station BanDaraJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {  },
            Name = "Ban Dara Junction",
            LocalName = "ชุมทางบ้านดารา",
            Remarks = "The terminal of Sawankhalok Line"
        };


        public static Station KhlongMaphlap  = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khlong Maphlap",
            LocalName = "คลองมะพลับ",
            Remarks = ""
        };

        public static Station SawanKhalok = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sawan Khalok",
            LocalName = "สวรรคโลก",
            Remarks = ""
        };

        #endregion


        #region Northern Line Main Stations


        
          public static Station Rangsit = new Station
          {
              Type = 'T',
              Destinations = new List<Destination> { },
              Name = "Rangsit",
              LocalName = "",
              Remarks = ""
          };

        public static Station Ayutthaya = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ayutthaya",
            LocalName = "อยุธยา",
            Remarks = "https://en.wikipedia.org/wiki/Ayutthaya_railway_station"
        };

        public static Station BanPhachiJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pachi Junction",
           Remarks ="Start for NorthEast Line"
        };

        public static Station LopBuri = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lop Buri",
            LocalName = "ลพบุรี",
            Remarks = ""
        };

        public static Station BanTakhli = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Takhli",
            LocalName = "",
            Remarks = ""
        };

        public static Station NakhonSawan = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Sawan",
            LocalName = "",
            Remarks = ""
        };

        public static Station TaphanHin = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Taphan Hin",
            LocalName = "",
            Remarks = ""
        };
        public static Station Phichit = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phichit",
            LocalName = "",
            Remarks = ""
        };

        public static Station Phitsanulok = new Station
        {            
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Sukhothai , ThailandDestinations.Phitsanulok },
            Name = "Phitsanulok",
            LocalName = "พิษณุโลก",
            Remarks = ""
        };

        public static Station Uttaradit = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Uttaradit",
            LocalName = "",
            Remarks = ""
        };

        public static Station SilaAt = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sila At",
            LocalName = "",
            Remarks = ""
        };

        public static Station DenChai = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Den Chai",
            LocalName = "",
            Remarks = ""
        };

        public static Station BanPin = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pin",
            LocalName = "",
            Remarks = ""
        };

        public static Station NakhonLampang = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nakhon Lampang",
            LocalName = "",
            Remarks = ""
        };

        public static Station HangChat = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hang Chat",
            LocalName = "",
            Remarks = ""
        };

        public static Station Lamphun = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lamphun",
            LocalName = "",
            Remarks = ""
        };

        public static Station ChiangMai = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.ChiangMai },
            Name = "Chiang Mai",
            LocalName = "",
            Remarks = ""
        };

        #endregion


        #region NorthEast Line Main Stations UbonRatchathani Branch

        //BanPachi
        public static Station BanPachi = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Pachi",
            LocalName = "",
            Remarks = ""
        };

        //Thanon Chira Junction
        public static Station ThanonChiraJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thanon Chira Junction",
            LocalName = "",
            Remarks = ""
        };

        //Surin
        public static Station Surin = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Surin",
            LocalName = "",
            Remarks = ""
        };

        //Sisaket
        public static Station Sisaket = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sisaket",
            LocalName = "",
            Remarks = ""
        };


        //UbonRatchathani
        public static Station UbonRatchathani = new Station
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
        public static Station KaengKhoiJuction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Kaeng Khoi Juction",
            LocalName = "",
            Remarks = ""
        };

        //Bua Yai Junction

        public static Station BuaYaiJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Bua Yai Junction",
            LocalName = "",
            Remarks = ""
        };

        //Khon Kaen

        public static Station KhonKaen = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Khon Kaen",
            LocalName = "",
            Remarks = ""
        };
        //Udon Thani

        public static Station UdonThani = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {  },
            Name = "Udon Thani",
            LocalName = "",
            Remarks = ""
        };


        //Nong Khai
        public static Station NongKhai = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> {ThailandDestinations.NongKhai, LaosDestinations.NongKhiang },
            Name = "Nong Khai",
            LocalName = "",
            Remarks = ""
        };
        #endregion

        #region NorthEast Line Main Stations Branch

        //Thanon Chira Junction
        //Bua Yai Junction

        #endregion

        public static Station Pattaya = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Pattaya",
            LocalName = "",
            Remarks = ""
        };

        public static Station Aranyaprathet = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Aranyaprathet },
            Name = "Aranyaprathet",
            LocalName = "",
            Remarks = ""
        };



        #region Eastern Line

        public static Station ChachengsaoJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chachengsao Junction",
            LocalName = "",
            Remarks = ""
        };

        public static Station Chonburi = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Chonburi",
            LocalName = "",
            Remarks = ""
        };

        public static Station SriRachaJunction = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Sri Racha Junction",
            LocalName = "",
            Remarks = ""
        };

        public static Station BanPluTaLuang = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ban Plu Ta Luang",
            LocalName = "",
            Remarks = ""
        };

        public static Station MarpTaPut = new Station
        {
            Type = 'T',
            Destinations = new List<Destination> { ThailandDestinations.Rayong},
            Name = "MarpTaPut",
            LocalName = "",
            Remarks = ""
        };

        #endregion
    }
}
