using Domain;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Vietnam
{
    public class VietnamTrainStations
    {

        #region North–South railway

        public static Station Hanoi = new Station
        {
            Type = 'T',      
            ServingDestinations = new List<Destination> { VietnamDestinations.Hanoi, VietnamDestinations.HAN },
            Name = "Hanoi",
            LocalName = "Ga Hà Nội",
            Remarks = ""
        };


        //Phủ Lý station
        //Nam Định station(Nam Định, Nam Định Province)
        //Thanh Hóa station(Thanh Hóa, Thanh Hóa Province)
        //Vinh station(Vinh, Nghệ An Province)
        //Tân Ấp station(Tân Ấp, Quảng Bình Province)
        //Đồng Hới station(Đồng Hới, Quảng Bình Province)
        //Đông Hà station(Đông Hà, Quảng Trị Province)
        //Huế station(Huế, Thừa Thiên–Huế Province)

        public static Station Huế = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> {  },
            Name = "Huế",
            LocalName = "Huế",
            Remarks = ""
        };

        //Da Nang station(Da Nang)
        public static Station DaNang = new Station
        {
            Type = 'T',

            ServingDestinations = new List<Destination> { },
            Name = "Da Nang",
            LocalName = "Da Nang",
            Remarks = ""
        };

        //Tam Kỳ station(Tam Kỳ, Quảng Nam Province)
        //Quảng Ngãi station(Quảng Ngãi, Quảng Ngãi Province)
        //Diêu Trì station(Qui Nhơn, Bình Định Province)
        //Tuy Hòa station(Tuy Hòa, Phú Yên Province)
        //Nha Trang station(Nha Trang, Khánh Hòa Province)
        //Bình Thuận station(Phan Thiết, Bình Thuận Province)

        //Saigon station(Ho Chi Minh City)
        public static Station Saigon = new Station
        {
            Type = 'T',

            ServingDestinations = new List<Destination> { VietnamDestinations.HoChiMinh, VietnamDestinations.SGN },
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
        public static Station LàoCai = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> {  },
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
        public static Station Kép = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> { },
            Name = "Kép",
            Remarks = ""
        };

        //Lạng Sơn station(Lạng Sơn, Lạng Sơn Province)
        //Đồng Đăng station(Đồng Đăng, Lạng Sơn Province)

        public static Station DongDang = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> { },
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

        public static Station HaLong  = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> { },
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

        public static Station HaiPhong = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> { },
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

        public static Station TháiNguyên = new Station
        {
            Type = 'T',
            ServingDestinations = new List<Destination> { },
            Name = "Thái Nguyên",
            Remarks = ""
        };
        //Quán Triều station

        public static Station QuánTriều = new Station
                {
                    Type = 'T',
                    ServingDestinations = new List<Destination> { },
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
