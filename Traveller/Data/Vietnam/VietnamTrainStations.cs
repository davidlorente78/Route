using Domain;
using Domain.Transport.Railway;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Vietnam
{
    /// <summary>
    /// Al añadir Destination en Serving Destinations de debe dar de alta en Destinations e incluir el codigo de pais CountryID = 2
    /// </summary>
    public class VietnamTrainStations
    {

        #region North–South railway

        public static RailwayStation Hanoi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { VietnamDestinations.Hanoi },
            Name = "Hanoi",
            LocalName = "Ga Hà Nội",
            Remarks = ""
        };



        public static RailwayStation PhủLý = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Phủ Lý",
            LocalName = "Phủ Lý",
            Remarks = ""
        };

        public static RailwayStation NamĐịnh = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nam Định",
            LocalName = "Nam Định",
            Remarks = ""
        };


        public static RailwayStation NinhBinh = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Ninh Binh",
            LocalName = "  Ninh Binh",
            Remarks = ""
        };

        public static RailwayStation ThanhHóa = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thanh Hóa",
            LocalName = "Thanh Hóa",
            Remarks = ""
        };



        public static RailwayStation Vinh = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Vinh",
            LocalName = "Vinh",
            Remarks = ""
        };


        public static RailwayStation TânẤp = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Tân Ấp",
            LocalName = "Tân Ấp",
            Remarks = ""
        };

        public static RailwayStation ĐồngHới = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Đồng Hới",
            LocalName = "Đồng Hới",
            Remarks = ""
        };



        public static RailwayStation ĐồngHà = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Đồng Hà",
            LocalName = "Đồng Hà",
            Remarks = ""
        };

        public static RailwayStation Huế = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Huế",
            LocalName = "Huế",
            Remarks = ""
        };

        public static RailwayStation DaNang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { VietnamDestinations.HoiAn },
            Name = "Da Nang",
            LocalName = "Da Nang",
            Remarks = ""
        };


        public static RailwayStation TamKỳ = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Tam Kỳ",
            LocalName = "Tam Kỳ",
            Remarks = ""
        };

        public static RailwayStation QuảngNgãi = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Quảng Ngãi",
            LocalName = "Quảng Ngãi",
            Remarks = ""
        };
        public static RailwayStation DiêuTrì = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { VietnamDestinations.QuiNhon },
            Name = "Diêu Trì",
            LocalName = "Diêu Trì",
            Remarks = ""
        };
        public static RailwayStation TuyHòa = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Tuy Hòa",
            LocalName = "Tuy Hòa",
            Remarks = ""
        };

        public static RailwayStation NhaTrang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Nha Trang",
            LocalName = "Nha Trang",
            Remarks = ""
        };

        public static RailwayStation BìnhThuận = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { VietnamDestinations.PhanThiet },
            Name = "Bình Thuận",
            LocalName = "Bình Thuận",
            Remarks = ""
        };

        public static RailwayStation Saigon = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { VietnamDestinations.HoChiMinh },
            Name = "Saigon",
            Remarks = ""
        };


        #endregion

        #region Hanoi–Lào Cai railway

        //Hanoi station(Hanoi)
        //Long Biên station(Hanoi)
        //Gia Lâm station(Hanoi)
        //Yên Viên station(Hanoi)
        //Đông Anh station(Hanoi)
        //Việt Trì station(Việt Trì, Phú Thọ Province)
        //Phú Thọ station(Phú Thọ, Phú Thọ Province)
        //Yên Bái station(Yên Bái, Yên Bái Province)

        //Lào Cai station(Lào Cai, Lào Cai Province)
        public static RailwayStation LàoCai = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Lào Cai",
            Remarks = ""
        };

        #endregion

        #region     Hanoi–Đồng Đăng railway

        //Hanoi station(Hanoi)
        //Long Biên station(Hanoi)
        //Gia Lâm station(Hanoi)
        //Yên Viên station(Hanoi)
        //Bắc Ninh station(Bắc Ninh, Bắc Ninh Province)
        //Bắc Giang station(Bắc Giang, Bắc Giang Province)

        //Kép station(Kép, Bắc Giang Province)
        public static RailwayStation Kép = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Kép",
            Remarks = ""
        };

        //Lạng Sơn station(Lạng Sơn, Lạng Sơn Province)
        //Đồng Đăng station(Đồng Đăng, Lạng Sơn Province)

        public static RailwayStation DongDang = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Đồng Đăng",
            LocalName = "Đồng Đăng",
            Remarks = ""
        };

        #endregion

        #region    Kép–Hạ Long railway

        //Kép station(Kép, Bắc Giang Province)
        //Lan Mẫu station(Lan Mẫu, Bắc Giang Province)
        //Mạo Khê station(Mạo Khê, Quảng Ninh Province)
        //Uông Bí station(Uông Bí, Quảng Ninh Province)
        //Yên Cư station(Yên Cư, Quảng Ninh Province)
        //Hạ Long station(Hạ Long, Quảng Ninh Province)

        public static RailwayStation HaLong = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hạ Long ",
            Remarks = ""
        };

        #endregion

        #region  Hanoi–Haiphong railway

        //Hanoi station(Hanoi)
        //Long Biên station(Hanoi)
        //Gia Lâm station(Hanoi)
        //Hải Dương station(Hải Dương, Hải Dương Province)
        //Hai Phong station(Hai Phong)

        public static RailwayStation HaiPhong = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Hai Phong ",
            Remarks = ""
        };


        #endregion

        #region    Hanoi–Thái Nguyên railway

        //Hanoi station
        //Long Biên station
        //Gia Lâm station
        //Yên Viên station
        //Đông Anh station
        //Lưu Xá station

        //Thái Nguyên station
        public static RailwayStation TháiNguyên = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Thái Nguyên",
            Remarks = ""
        };

        //Quán Triều station
        public static RailwayStation QuánTriều = new RailwayStation
        {
            Type = 'T',
            Destinations = new List<Destination> { },
            Name = "Quán Triều",
            Remarks = ""
        };

        #endregion

        #region Thái Nguyên–Kép

        //Lưu Xá station
        //Kép station

        #endregion
    }
}
