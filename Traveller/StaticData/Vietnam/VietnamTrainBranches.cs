using Domain;
using Domain.Transport.Railway;

namespace StaticData.Vietnam
{
    public static class VietnamTrainBranches
    {

        public static RailwayBranch NorthSouth = new RailwayBranch
        {

            Name = "North–South Line",
            MainBranch = true,
            Description = "",
            Stations = new List<RailwayStation>
            {
                VietnamTrainStations.Hanoi,      
                //VietnamTrainStations.PhủLý,
                //VietnamTrainStations.NamĐịnh,
                VietnamTrainStations.NinhBinh,
                VietnamTrainStations.ThanhHóa,
                VietnamTrainStations.Vinh,
                VietnamTrainStations.TânẤp,
                VietnamTrainStations.ĐồngHới,
                VietnamTrainStations.ĐồngHà,
                VietnamTrainStations.Huế,
                VietnamTrainStations.DaNang,
                VietnamTrainStations.TamKỳ,
                VietnamTrainStations.QuảngNgãi,
                VietnamTrainStations.DiêuTrì,
                VietnamTrainStations.TuyHòa,
                VietnamTrainStations.NhaTrang,
                //VietnamTrainStations.ThapCham,
                //VietnamTrainStations.PhanThiet,
                VietnamTrainStations.BìnhThuận,                
                VietnamTrainStations.Saigon

            }

        };


        public static RailwayBranch HanoiLàoCai = new RailwayBranch
        {

            Name = "Hanoi–Lào Cai Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.LàoCai,
            }
        };

        public static RailwayBranch HanoiĐồngĐăng = new RailwayBranch
        {

            Name = "Hanoi–Đồng Đăng Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.Kép,
               VietnamTrainStations.DongDang,
            }
        };

        public static RailwayBranch KépHạLong = new RailwayBranch
        {

            Name = "Kép–Hạ Long Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.Kép,
               VietnamTrainStations.HaLong,
            }
        };

        public static RailwayBranch HanoiHaiphong = new RailwayBranch
        {

            Name = "Hanoi–Haiphong Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.HaiPhong,
            }
        };

        public static RailwayBranch HanoiTháiNguyên = new RailwayBranch
        {

            Name = "Hanoi–Thái Nguyên Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.TháiNguyên,
               VietnamTrainStations.QuánTriều,
            }
        };

        public static RailwayBranch TháiNguyênKép = new RailwayBranch
        {
            Name = "Thái Nguyên–Kép Line",
            Description = "",
            MainBranch = true,
            Stations = new List<RailwayStation>
            {
               VietnamTrainStations.TháiNguyên,
               VietnamTrainStations.Kép,
            }
        };



    }
}
