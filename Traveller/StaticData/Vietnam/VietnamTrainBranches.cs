using Domain;

namespace StaticData.Vietnam
{
    public static class VietnamTrainBranches
    {

        public static Branch NorthSouth = new Branch
        {

            Name = "North–South Line",
            MainBranch = true,
            Description = "",
            Stations = new List<Station>
            {
                VietnamTrainStations.Hanoi,
                VietnamTrainStations.Huế,
                VietnamTrainStations.DaNang,           
                VietnamTrainStations.Saigon

            }

        };


        public static Branch HanoiLàoCai = new Branch
        {

            Name = " Hanoi–Lào Cai Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.LàoCai,
            }
        };

        public static Branch HanoiĐồngĐăng = new Branch
        {

            Name = "Hanoi–Đồng Đăng Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {
               VietnamTrainStations.Hanoi,
               VietnamTrainStations.Kép,
               VietnamTrainStations.DongDang,
            }
        };

        public static Branch KépHạLong = new Branch
        {

            Name = "Kép–Hạ Long Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {
             
               VietnamTrainStations.Kép,
               VietnamTrainStations.HaLong,
            }
        };

        public static Branch HanoiHaiphong = new Branch
        {

            Name = "Hanoi–Haiphong Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {

               VietnamTrainStations.Hanoi,
               VietnamTrainStations.HaiPhong,
            }
        };

        public static Branch HanoiTháiNguyên = new Branch
        {

            Name = "Hanoi–Thái Nguyên Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {

               VietnamTrainStations.Hanoi,
               VietnamTrainStations.TháiNguyên,
               VietnamTrainStations.QuánTriều,
            }
        };

        public static Branch TháiNguyênKép = new Branch
        {

            Name = "Thái Nguyên–Kép Line",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
            {

               VietnamTrainStations.TháiNguyên,
               VietnamTrainStations.Kép,
            }
        };

        

    }
}
