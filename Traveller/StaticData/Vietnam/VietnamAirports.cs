using Domain.Transport.Aviation;
using Data.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Vietnam
{
    public class VietnamAirports
    {
        #region International Airports
        public static Airport SGN = new Airport
        {
            Name = "Tan Son Nhat International Airport",
            Destinations = new List<Destination> { VietnamDestinations.HoChiMinh },
            IATACode = "SGN",
            AirportType = AirportTypes.International

        };

        public static Airport HAN = new Airport
        {
            Name = "Noi Bai International Airport",
            Destinations = new List<Destination> { VietnamDestinations.Hanoi },
            IATACode = "HAN",
            AirportType = AirportTypes.International

        };

        public static Airport DAD = new Airport
        {
            Name = "Da Nang International Airport",
            Destinations = new List<Destination> { VietnamDestinations.Danang },
            IATACode = "DAD",
            AirportType = AirportTypes.International

        };

        public static Airport HPH = new Airport
        {
            Name = "Cat Bi International Airport",
            Destinations = new List<Destination> { VietnamDestinations.Haiphong },
            IATACode = "HPH",
            AirportType = AirportTypes.International

        };


        public static Airport VCL = new Airport
        {
            Name = "Chu Lai International Airport",
            Destinations = new List<Destination> { VietnamDestinations.DungQuatBay },
            IATACode = "VCL",
            AirportType = AirportTypes.International

        };


        public static Airport PQC = new Airport
        {
            Name = "Phu Quoc International Airport",
            Destinations = new List<Destination> { VietnamDestinations.PhuQuoc },
            IATACode = "PQC",
            AirportType = AirportTypes.International

        };

        public static Airport VCA = new Airport
        {
            Name = "Can Tho International Airport",
            Destinations = new List<Destination> { VietnamDestinations.CanTho },
            IATACode = "VCA",
            AirportType = AirportTypes.International

        };

        public static Airport HUI = new Airport
        {
            Name = "Hue International Airport",
            Destinations = new List<Destination> { VietnamDestinations.Hue },
            IATACode = "HUI",
            AirportType = AirportTypes.International

        };

        #endregion

        #region Domestic Airports
        //BMV Buon Ma Thuot Airport Buon Ma Thuot	3	4
        public static Airport BMV = new Airport
        {
            Name = "Buon Ma Thuot Airport",
            Destinations = new List<Destination> { VietnamDestinations.BuonMaThuot },
            IATACode = "BMV",
            AirportType = AirportTypes.Domestic

        };

        public static Airport CXR = new Airport
        {
            Name = "Cam Ranh Airport",
            Destinations = new List<Destination> { VietnamDestinations.NhaTrang },
            IATACode = "CXR",
            AirportType = AirportTypes.Domestic

        };

        public static Airport VII = new Airport
        {
            Name = "Vinh Airport",
            Destinations = new List<Destination> { VietnamDestinations.Vinh },
            IATACode = "VII",
            AirportType = AirportTypes.Domestic

        };

        public static Airport DLI = new Airport
        {
            Name = "Lien Khuong Airport",
            Destinations = new List<Destination> { VietnamDestinations.DaLat },
            IATACode = "DLI",
            AirportType = AirportTypes.Domestic

        };

        public static Airport UIH = new Airport
        {
            Name = "Phu Cat Airport",
            Destinations = new List<Destination> { VietnamDestinations.QuyNohn },
            IATACode = "UIH",
            AirportType = AirportTypes.Domestic

        };

        public static Airport CAH = new Airport
        {
            Name = "Cà Mau Airport",
            Destinations = new List<Destination> { VietnamDestinations.CàMau },
            IATACode = "CAH",
            AirportType = AirportTypes.Domestic

        };

        public static Airport VCS = new Airport
        {
            Name = "Co Ong Airport",
            Destinations = new List<Destination> { VietnamDestinations.ConDao },
            IATACode = "VCS",
            AirportType = AirportTypes.Domestic

        };

        public static Airport DIN = new Airport
        {
            Name = "Dien Bien Phu Airport",
            Destinations = new List<Destination> { VietnamDestinations.DienBienPhu },
            IATACode = "DIN",
            AirportType = AirportTypes.Domestic

        };
        public static Airport PXU = new Airport
        {
            Name = "Pleiku Airport",
            Destinations = new List<Destination> { VietnamDestinations.Pleiku },
            IATACode = "PXU",
            AirportType = AirportTypes.Domestic

        };

        public static Airport VKG = new Airport
        {
            Name = "Rach Gia Airport",
            Destinations = new List<Destination> { VietnamDestinations.RachGia },
            IATACode = "VKG",
            AirportType = AirportTypes.Domestic

        };

        public static Airport TBB = new Airport
        {
            Name = "Dong Tac Airport",
            Destinations = new List<Destination> { VietnamDestinations.TuyHoa },
            IATACode = "TBB",
            AirportType = AirportTypes.Domestic

        };

        public static Airport VDH = new Airport
        {
            Name = "Dong Hoi Airport",
            Destinations = new List<Destination> { VietnamDestinations.DongHoi },
            IATACode = "VDH",
            AirportType = AirportTypes.Domestic

        };

        #endregion

        public static ICollection<Airport> GetAll()
        {


            return new List<Airport> {
                SGN,
                HUI,
                HAN,
                VCA,
                PQC,
                VCL,
                HPH,
                DAD,
                BMV,
                CXR,
                VII,
                DLI ,
                UIH ,
                CAH ,
                VCS ,
                DIN ,
                PXU ,
                VKG ,
                TBB ,
                VDH

            };
        }
    }
}
