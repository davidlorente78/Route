using Domain;
using Domain.Transport.Railway;

namespace Data.Thailand
{
    public static class ThailandTrainBranches
    {
        //TODO Khiri Ratthanikhom
        public static RailwayBranch SouthernLine = new RailwayBranch
        {
            Name = "Southern Line",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {   ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.Ratchaburi,
                ThailandTrainStations.Phetchaburi,
                ThailandTrainStations.HuaHin,
                ThailandTrainStations.PrachuapKhiriKhan,   
                ThailandTrainStations.Chumphon,
                ThailandTrainStations.LangSuan,
                ThailandTrainStations.SuratThani,
                ThailandTrainStations.ThungSongJunction,
                ThailandTrainStations.Phatthalung,
                ThailandTrainStations.HatYaiJunction,
                ThailandTrainStations.Pattani,
                ThailandTrainStations.Yala,
                ThailandTrainStations.TanyongMat,
                ThailandTrainStations.SungaiKolok
            },  
        };
       
        public static RailwayBranch SouthernLine_KantangBranch = new RailwayBranch
        {            
            Name = "Southern Line Kantang Branch",
            Description = "Southern Line Kantang Branch",
            MainBranch = false,
            Stations = new List<RailwayStation>
            {
                ThailandTrainStations.ThungSongJunction,
                ThailandTrainStations.Trang,
                ThailandTrainStations.Kantang,               
            } 
        };

        public static RailwayBranch SouthernLine_PadangBesar = new RailwayBranch
        {
            Name = "Southern Line Padang Besar Branch",
            Description = "Southern Line Padang Besar Branch",
            MainBranch = false,
            Stations = new List<RailwayStation>
            {
                ThailandTrainStations.HatYaiJunction,
                ThailandTrainStations.PadangBesar,          
            } ,
        };

        public static RailwayBranch NorthernLine= new RailwayBranch
        {
            Name = "Northern Line",
            Description = "Northern Line",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
                ThailandTrainStations.BangkokHuaLamphong,
                //Yommarat
                //Ho Prajae Chit Lada
                //Ramathibodi Hospital
                //Sam Sen
                //Bang Sue Junction
                //Nikhom Rotfai KM. 11
                //Bang Khen
                //Thung Song Hong
                //Lak Si
                //Kan Keha KM. 19
                //Don Mueang
                ThailandTrainStations.Rangsit,
                //Khlong Nueng
                //Chiang Rak
                //Thammasat University
                //Nava Nakhon
                //Chiang Rak Noi
                //Khlong Phutsa
                //Bang Pa-In
                //Ban Pho
                ThailandTrainStations.Ayutthaya,
                //Ban Ma
                //Map Phra Chan
                //Ban Don Klang
                //Phra Kaeo
                //Ban Phachi Junction
                ThailandTrainStations.BanPhachiJunction,
                //Don Ya Nang
                //Nong Wiwat
                //Ban Plak Raet
                //Tha Ruea
                //Ban Mo
                //Nong Don
                //Ban Klap
                //Ban Pa Wai
                ThailandTrainStations.LopBuri,
                //Tha Khae
                //Khok Kathiam
                //Nong Tao
                //Nong Sai Khao
                //Ban Mi
                //Huai Kaeo
                //Phai Yai
                //Rong Rien Chansen
                //Chansen
                //Ban Kok Kwaow
                //Chong Khae
                //Thale Wa
                //Phon Thong
                ThailandTrainStations.BanTakhli,
                //Dong Maku
                //Hua Wai
                //Nong Pho
                //Hua Ngiu
                //Noen Makok
                //Khao Thong
               ThailandTrainStations.NakhonSawan,
                //Pak Nam Pho
                //Bueng Boraphet
                //Thap Krit
                //Khlong Pla Kot
                //Chumsaeng
                //Wang Krang
                //Bang Mun Nak
                //Ho Krai
                //Dong Takhop
                ThailandTrainStations.TaphanHin,
                //Huai Ket
                //Hua Dong
                //Wang Krot
                ThailandTrainStations.Phichit,
                //Tha Lo
                //Bang Krathum
                //Mae Thiap
                //Ban Mai
                //Bueng Phra
                ThailandTrainStations.Phitsanulok,
                //Ban Teng Nam
                //Ban Tum
                //Khwae Noi
                //Phrom Phiram
                //Nong Tom
                //Ban Bung
                //Ban Khon
                //Phichai
                //Rai Oi
                ThailandTrainStations.BanDaraJunction,
                //Tha Sak
                //Tron
                //Wang Kaphi
                ThailandTrainStations.Uttaradit,
                ThailandTrainStations.SilaAt,
                //Tha Sao
                //Ban Dan
                //Pang Ton Phueng
                //Pang Tub Khob Tunnel length 102.09 m (513.72-513.84)
                //Khao Phlueng Tunnel length 362.44 m (516.41-516.77)
                //Khao Phlung
                //Huai Rai
                //Rai Kled Dao
                //Mae Phuak
               ThailandTrainStations.DenChai,
                //Pak Pan
                //Kaeng Luang
                //Huai Mae Ta
                ThailandTrainStations.BanPin,
                //Huai Mae Lan Tunnel length 130.20 m (574.04-574.17)
                //Pha Khan
                //Pha Kho
                //Pang Puai
                //Mae Chang
                //Mae Mo
                //Huai Rak Mai
                //Sala Pha Lat
                //Mae Tha
                //Nong Wua Thao
                ThailandTrainStations.NakhonLampang,
                ThailandTrainStations.HangChat,
                //Pang Muang
                //Huai Rian
                //Mae Tan Noi
                //Khun Tan Tunnel length 1352.10 m (681.57-682.93)
                //Khun Tan
                //Tha Chomphu
                //Sala Mae Tha
                //Nong Lom
                ThailandTrainStations.Lamphun,
                //Pa Sao
                //Saraphi
                ThailandTrainStations.ChiangMai
            } ,
        };

        public static RailwayBranch NorthernLine_Sawankhalok = new RailwayBranch
        {
            Name = "Northern Line Sawan Khalok Branch",
            Description = "Northern Line Sawan Khalok Branch",
            MainBranch = false,
            Stations = new List<RailwayStation>
            {
                ThailandTrainStations.BanDaraJunction,
                ThailandTrainStations.KhlongMaphlap,
                ThailandTrainStations.SawanKhalok,
            } ,
        };

        public static RailwayBranch NorthEasternLine_UbonRatchathani = new RailwayBranch
        {
            Name = "North East Line Ubon Ratchathani Branch",
            Description = "North East Line Ubon Ratchathani Branch",
            MainBranch = true,
            Stations = new List<RailwayStation>
             {
                ThailandTrainStations.BanPachi,
                ThailandTrainStations.KaengKhoiJuction,
                ThailandTrainStations.ThanonChiraJunction,
                ThailandTrainStations.Surin,
                ThailandTrainStations.Sisaket,
                ThailandTrainStations.UbonRatchathani,
             },
        };

        public static RailwayBranch NorthEasternLineLine_NongKhai = new RailwayBranch
        {
            Name = "North East Line Ubon NongKhai Branch",
            Description = "North East Line Ubon NongKhai Branch",
            MainBranch = true,
            Stations = new List<RailwayStation>
             {
                ThailandTrainStations.BanPachi,
                ThailandTrainStations.KaengKhoiJuction,
                ThailandTrainStations.BuaYaiJunction,
                ThailandTrainStations.KhonKaen,
                ThailandTrainStations.UdonThani,
                ThailandTrainStations.NongKhai,
             },
        };

        public static RailwayBranch NorthEasternLine_BuaYai_ThanonChira = new RailwayBranch
        {
            Name = "North East Line Bua Yai Junction - Thanon Chira Junction Branch",
            Description = "North East Line Bua Yai Junction - Thanon Chira Junction Branch",
            MainBranch = false,
            Stations = new List<RailwayStation>
             {
                ThailandTrainStations.BuaYaiJunction,
                ThailandTrainStations.ThanonChiraJunction,              
             }
        };

        public static RailwayBranch EasternLine_Pattaya = new RailwayBranch
        {
            Name = "Eastern Line Pattaya",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
             {
                ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.ChachengsaoJunction,
                ThailandTrainStations.Chonburi,
                ThailandTrainStations.SriRachaJunction,
                ThailandTrainStations.Pattaya,
                ThailandTrainStations.BanPluTaLuang,
             },
        };

        public static RailwayBranch EasternLine_Pattaya_MarpTaPutBranch = new RailwayBranch
        {
            Name = "Eastern Line Pattaya - MarpTaPut Branch ",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
             {        
                ThailandTrainStations.Pattaya,
                ThailandTrainStations.MarpTaPut,
             }
        };

        public static RailwayBranch EasternLine_Aranyaprathet = new RailwayBranch
        {
            Name = "Eastern Line Pattaya - Aranyaprathet  Branch ",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
                ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.Aranyaprathet,
            },
        };

        public static ICollection<RailwayBranch> GetSoutherLineAllBranches()
        {
            //Branch Lines must be returned here in order to avoid Key message error
            return new List<RailwayBranch> { SouthernLine , SouthernLine_KantangBranch , SouthernLine_PadangBesar };
        }
    }
}
