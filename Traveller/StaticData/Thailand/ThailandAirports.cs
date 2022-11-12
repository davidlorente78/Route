using Domain.Transport.Aviation;
using StaticData.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Thailand
{
    public class ThailandAirports
    {

        #region International Airports

        public static Airport BKK = new Airport
        {
            Name = "Suvarnabhumi Airport",
            Destinations = new List<Destination> { ThailandDestinations.Bangkok, ThailandDestinations.SamutPrakan },
            ICAOCode = "VTBS",
            IATACode = "BKK",
            AirportType = AirportTypes.International

        };

        public static Airport DMK = new Airport
        {
            Name = "Don Mueang International Airport",
            Destinations = new List<Destination> { ThailandDestinations.Bangkok, ThailandDestinations.Nonthaburi, ThailandDestinations.PathumThani },
            ICAOCode = "VTBD",
            IATACode = "DMK",
            AirportType = AirportTypes.International
        };

        public static Airport BTZ = new Airport
        {
            Name = "Betong International Airport",
            Destinations = new List<Destination> { ThailandDestinations.Betong, ThailandDestinations.Yala, ThailandDestinations.PathumThani },
            ICAOCode = "VTSY",
            IATACode = "BTZ",
            AirportType = AirportTypes.International
        };

        public static Airport CNX = new Airport
        {
            Name = "Chiang Mai International Airport",
            Destinations = new List<Destination> { ThailandDestinations.ChiangMai, ThailandDestinations.Lamphun },
            ICAOCode = "VTCC",
            IATACode = "CNX",
            AirportType = AirportTypes.International
        };

        public static Airport CEI = new Airport
        {
            Name = "Mae Fah Luang Chiang Rai International Airport",
            Destinations = new List<Destination> { ThailandDestinations.ChiangRai },
            ICAOCode = "VTCT",
            IATACode = "CEI",
            AirportType = AirportTypes.International
        };

        public static Airport HDY = new Airport
        {
            Name = "Hat Yai International Airport",
            Destinations = new List<Destination> { ThailandDestinations.HatYai, ThailandDestinations.Songkhla },
            ICAOCode = "VTSS",
            IATACode = "HDY",
            AirportType = AirportTypes.International
        };

        public static Airport HKT = new Airport
        {
            Name = "Phuket International Airport",
            Destinations = new List<Destination> { ThailandDestinations.Phuket },
            ICAOCode = "VTSP",
            IATACode = "HKT",
            AirportType = AirportTypes.International
        };

        public static Airport USM = new Airport
        {
            Name = "Samui International Airport",
            Destinations = new List<Destination> { ThailandDestinations.KoSamui },
            ICAOCode = "VTSM",
            IATACode = "USM",
            AirportType = AirportTypes.International
        };

        public static Airport KBV = new Airport
        {
            Name = "Krabi International Airport",
            Destinations = new List<Destination> { ThailandDestinations.Krabi },
            ICAOCode = "VTSG",
            IATACode = "KBV",
            AirportType = AirportTypes.International
        };

        public static Airport URT = new Airport
        {
            Name = "Surat Thani International Airport",
            Destinations = new List<Destination> { ThailandDestinations.SuratThani },
            ICAOCode = "VTSB",
            IATACode = "URT",
            AirportType = AirportTypes.International
        };

        public static Airport UTP = new Airport
        {
            Name = "U-Tapao International Airport",
            Destinations = new List<Destination> { ThailandDestinations.Rayong , ThailandDestinations.Pattaya },
            ICAOCode = "VTBU",
            IATACode = "UTP",
            AirportType = AirportTypes.International
        };

        public static Airport UTH = new Airport
        {
            Name = "Udon Thani International Airport",
            Destinations = new List<Destination> { ThailandDestinations.UdonThani },
            ICAOCode = "VTUD",
            IATACode = "UTH",
            AirportType = AirportTypes.International
        };

        #endregion


        public static Airport BFV = new Airport
        {
            Name = "Buriram Airport",
            Destinations = new List<Destination> { ThailandDestinations.Burinam },
            ICAOCode = "VTUO",
            IATACode = "BFV",
            AirportType = AirportTypes.Domestic
        };

        public static Airport CJM = new Airport
        {
            Name = " Chumphon Airport",
            Destinations = new List<Destination> { ThailandDestinations.Chumphon },
            ICAOCode = "VTSE",
            IATACode = "CJM",
            AirportType = AirportTypes.Domestic
        };

        public static Airport HHQ = new Airport
        {
            Name = "Hua Hin Airport",
            Destinations = new List<Destination> { ThailandDestinations.HuaHin, ThailandDestinations.PrachuapKhiriKhan },
            ICAOCode = "VTPH",
            IATACode = "HHQ",
            AirportType = AirportTypes.Domestic
        };

        public static Airport KKC = new Airport
        {
            Name = "Khon Kaen Airport",
            Destinations = new List<Destination> { ThailandDestinations.KhonKaen },
            ICAOCode = "VTUK",
            IATACode = "KKC",
            AirportType = AirportTypes.Domestic
        };

        public static Airport LPT = new Airport
        {
            Name = "Lampang Airport",
            Destinations = new List<Destination> { ThailandDestinations.Lampang },
            ICAOCode = "VTCL",
            IATACode = "LPT",
            AirportType = AirportTypes.Domestic
        };
        public static Airport LOE = new Airport
        {
            Name = "Loei Airport",
            Destinations = new List<Destination> { ThailandDestinations.Loei },
            ICAOCode = "VTUL",
            IATACode = "LPT",
            AirportType = AirportTypes.Domestic
        };
        public static Airport HGN = new Airport
        {
            Name = "Mae Hong Son Airport",
            Destinations = new List<Destination> { ThailandDestinations.MaeHongSon },
            ICAOCode = "VTCH",
            IATACode = "LPT",
            AirportType = AirportTypes.Domestic
        };

        public static Airport MAQ = new Airport
        {
            Name = "Mae Sot Airport",
            Destinations = new List<Destination> { ThailandDestinations.MaeSot, ThailandDestinations.Tak },
            ICAOCode = "VTPM",
            IATACode = "MAQ",
            AirportType = AirportTypes.Domestic
        };

        public static Airport KOP = new Airport
        {
            Name = "Nakhon Phanom Airport",
            Destinations = new List<Destination> { ThailandDestinations.NakhonPhanom },
            ICAOCode = "VTUW",
            IATACode = "KOP",
            AirportType = AirportTypes.Domestic
        };
        public static Airport NAK = new Airport
        {
            //Khorat
            Name = "Nakhon Ratchasima Airport",
            Destinations = new List<Destination> { ThailandDestinations.NakhonRatchasima },
            ICAOCode = "VTUQ",
            IATACode = "NAK",
            AirportType = AirportTypes.Domestic
        };

        public static Airport NST = new Airport
        {
            Name = "Nakhon Si Thammarat Airport",
            Destinations = new List<Destination> { ThailandDestinations.NakhonSiThammarat },
            ICAOCode = "VTSF",
            IATACode = "NST",
            AirportType = AirportTypes.Domestic
        };

        public static Airport NNT = new Airport
        {
            Name = "Nan Nakhon Airport",
            Destinations = new List<Destination> { ThailandDestinations.NanNakhon },
            ICAOCode = "VTSF",
            IATACode = "NNT",
            AirportType = AirportTypes.Domestic
        };

        public static Airport NAW = new Airport
        {
            Name = "Narathiwat Airport",
            LocalName = "ท่าอากาศยานนราธิวาส",
            Destinations = new List<Destination> { ThailandDestinations.Narathiwat },
            ICAOCode = "VTSC",
            IATACode = "NAW",
            AirportType = AirportTypes.Domestic
        };
        public static Airport PHY = new Airport
        {
            Name = "Phetchabun Airport",
            Destinations = new List<Destination> { ThailandDestinations.Phetchabun },
            ICAOCode = "VTPB",
            IATACode = "PHY",
            AirportType = AirportTypes.Domestic
        };

        public static Airport PHS = new Airport
        {
            Name = "Phitsanulok Airport",
            Destinations = new List<Destination> { ThailandDestinations.Phitsanulok },
            ICAOCode = "VTPP",
            IATACode = "PHS",
            AirportType = AirportTypes.Domestic
        };

        public static Airport PRH = new Airport
        {
            Name = "Phrae Airport",
            Destinations = new List<Destination> { ThailandDestinations.Phrae },
            ICAOCode = "VTCP",
            IATACode = "PRH",
            AirportType = AirportTypes.Domestic
        };

        public static Airport UNN = new Airport
        {
            Name = "Ranong Airport",
            Destinations = new List<Destination> { ThailandDestinations.Ranong },
            ICAOCode = "VTSR",
            IATACode = "UNN",
            AirportType = AirportTypes.Domestic
        };

        public static Airport ROI = new Airport
        {
            Name = "Roi Et Airport",
            Destinations = new List<Destination> { ThailandDestinations.RoiEt },
            ICAOCode = "VTUV",
            IATACode = "ROI",
            AirportType = AirportTypes.Domestic
        };

        public static Airport SNO = new Airport
        {
            Name = "Sakon Nakhon Airport",
            Destinations = new List<Destination> { ThailandDestinations.SakonNakhon },
            ICAOCode = "VTUI",
            IATACode = "SNO",
            AirportType = AirportTypes.Domestic
        };

        public static Airport THS = new Airport
        {   CountryID =3,
            Name = "Sukhothai Airport",
            Destinations = new List<Destination> { ThailandDestinations.Sukhothai },
            ICAOCode = "VTPO",
            IATACode = "THS",
            AirportType = AirportTypes.Domestic
        };

        public static Airport TST = new Airport
        {
            Name = "Trang Airport",
            Destinations = new List<Destination> { ThailandDestinations.Trang },
            ICAOCode = "VTST",
            IATACode = "TST",
            AirportType = AirportTypes.Domestic
        };

        public static Airport TDX = new Airport
        {
            Name = "Trat Airport",
            Destinations = new List<Destination> { ThailandDestinations.Trat },
            ICAOCode = "VTBO",
            IATACode = "TST",
            AirportType = AirportTypes.Domestic
        };

        public static Airport UBP = new Airport
        { 
            Name = "Ubon Ratchathani Airport",
            Destinations = new List<Destination> { ThailandDestinations.UbonRatchathani },
            ICAOCode = "VTUU",
            IATACode = "UBP",
            AirportType = AirportTypes.Domestic
        };


        public static ICollection<Airport> GetAll() {


            return new List<Airport> {
                    BKK,
                    DMK,
                    BTZ,
                    CNX,
                    CEI,
                    HDY,
                    HKT,
                    USM,
                    KBV,
                    URT,
                    UTP,
                    UTH,
                    BFV,
                    CJM,
                    HHQ,
                    KKC,
                    LPT,
                    LOE,
                    HGN,
                    MAQ,
                    KOP,
                    NAK,
                    NST,
                    NNT,
                    NAW,
                    PHY,
                    PHS,
                    PRH,
                    UNN,
                    ROI,
                    SNO,
                    THS,
                    TST,
                    TDX,
                    UBP
                    };
        }
    }
}
