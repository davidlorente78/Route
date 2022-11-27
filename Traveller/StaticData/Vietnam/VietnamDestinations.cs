using Data.EntityTypes;
using Data.Vietnam;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamDestinations
    {
        public static Destination MocBai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Moc Bai", Description = "Border town of Vietnam near Bavet (Cambodia)" };
        public static Destination VingXuong = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Ving Xuong", Description = "Vietnamese border town close to Kaam Samnor" };
        public static Destination NhapCanh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Nhap Canh" };
        public static Destination TayTrang = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Tay Trang", Description = "Ah 13, Na ư, h. Điện Biên, Điện Biên, Vietnam. Tay Trang, newly incorporated and with little traffic. Access to it was complicated and long, although the landscapes of Northern Laos are the most amazing in the whole country. The first city after crossing the border is Lai Chau, from where you can go to Sa Pa, a place where we can make many excursions through the mountains, rice fields and villages. It was our favorite in case we were encouraged to go to Sa Pa." };
        public static Destination LaoBao = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Bao" };
        public static Destination NaMeo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Border town in Vietnam very close to Tam Coc and Ninh Binh.", Name = "Na Meo" };
        public static Destination LaoCai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Cai" };
        public static Destination HaTien = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Border location in Vietnam near Chau Doc, used to enter or leave from Kampot (Cambodia) In front of Phu Quoc Island. ", Name = "Ha Tien / Xa Xia" };
        public static Destination CauTreo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Leaving from Lak Sao and following route 8 you arrive at this border locality. It gives access to Vietnam at the height of Vinh.", Name = "Cau Treo / Cao Tree" };
        public static Destination NinhBinh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Ninh Binh", Name = "Ninh Binh" };
        //Si esta relacionada con una estacion tambien debe tener CountryID para evitar conflicto con FK en inicializacion de Base de datos
        public static Destination HoiAn = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Hoi An", Name = "Hoi An" };
        public static Destination PhanThiet = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Phan Thiet", Name = "Phan Thiet" };
        public static Destination QuiNhon = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Qui Nhon", Name = "Qui Nhon" };
        /// Las localidades ligadas a un aeropuerto deben tener tambien informado el CountryID para evitar conflicto con FK
        public static Destination Hanoi = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport }, Name = "Hanoi" };
        public static Destination HoChiMinh = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Name = "Ho Chi Minh" };
        public static Destination Hue = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Hue", };
        public static Destination Danang = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Danang", };
        public static Destination Haiphong = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Hai Phong", };
        public static Destination DungQuatBay = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Dung Quat Bay", };
        public static Destination PhuQuoc = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Phu Quoc Island", };
        public static Destination CanTho = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Can Tho", };
        public static Destination BuonMaThuot = new Destination { DestinationCountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Buon Ma Thuot", LocalName = "Buôn Ma Thuột" };
        public static Destination DongHoi = new Destination { DestinationCountryID = 2, Name = "Dong Hoi", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination TuyHoa = new Destination { DestinationCountryID = 2, Name = "Tuy Hoa", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination RachGia = new Destination { DestinationCountryID = 2, Name = "Rach Gia", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination Pleiku = new Destination { DestinationCountryID = 2, Name = "Pleiku", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination DienBienPhu = new Destination { DestinationCountryID = 2, Name = "Dien Bien Phu", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination ConDao = new Destination { DestinationCountryID = 2, Name = "Con Dao", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination CàMau = new Destination { DestinationCountryID = 2, Name = "Cà Mau", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination QuyNohn = new Destination { DestinationCountryID = 2, Name = "Quy Nohn", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination DaLat = new Destination { DestinationCountryID = 2, Name = "Da Lat", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination Vinh = new Destination { DestinationCountryID = 2, Name = "Vinh", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination NhaTrang = new Destination { DestinationCountryID = 2, Name = "Nha Trang", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination ThuongPhuoc = new Destination { DestinationCountryID = 2, Name = "Thuong Phuoc", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier } };

        public static List<Destination> GetStaticAll()
        {
            return new List<Destination> {
                VietnamDestinations.VingXuong,
                VietnamDestinations.Hanoi,
                VietnamDestinations.MocBai,
                VietnamDestinations.HaTien,
                VietnamDestinations.TayTrang,
                VietnamDestinations.NhapCanh ,
                VietnamDestinations.LaoBao,
                VietnamDestinations.NaMeo,
                VietnamDestinations.NinhBinh,
                VietnamDestinations.LaoCai,
                VietnamDestinations.HaTien,
                VietnamDestinations.HoChiMinh,
                VietnamDestinations.CauTreo,
                VietnamDestinations.Hue,
                VietnamDestinations.HoiAn,
                VietnamDestinations.Danang,
                VietnamDestinations.Haiphong,
                VietnamDestinations.DungQuatBay,
                VietnamDestinations.PhuQuoc,
                VietnamDestinations.CanTho,
                VietnamDestinations.BuonMaThuot,
                VietnamDestinations.DongHoi,
                VietnamDestinations.TuyHoa,
                VietnamDestinations.RachGia,
                VietnamDestinations.Pleiku,
                VietnamDestinations.DienBienPhu,
                VietnamDestinations.ConDao,
                VietnamDestinations.CàMau,
                VietnamDestinations.QuyNohn,
                VietnamDestinations.DaLat,
                VietnamDestinations.Vinh,
                VietnamDestinations.NhaTrang,
                VietnamDestinations.ThuongPhuoc
            };
        }

        public static List<Destination> GetAll()

        {
            List<Destination> destinationsFromStatic = GetStaticAll();

            List<Destination> destinationsFromStations = CreateDestinationsFromStations();

            destinationsFromStatic.AddRange(destinationsFromStations);

            return destinationsFromStatic;

        }

        public static List<Destination> CreateDestinationsFromStations()
        {

            List<Destination> destinations = new List<Destination>();

            List<Destination> staticdestinations = GetStaticAll();

            var trainLines = VietnamTrainLines.GetAll();

            foreach (var trainLine in trainLines)
            {
                foreach (var branch in trainLine.Branches)
                {
                    foreach (var station in branch.Stations)
                    {
                        if (!staticdestinations.Where(x => x.Name == station.Name).Any())
                        {

                            Destination destination = new Destination
                            {
                                Name = station.Name,
                                DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
                            };

                            destinations.Add(destination);
                        }

                        else

                        {
                            var exist = staticdestinations.Where(x => x.Name == station.Name).FirstOrDefault();

                            exist.DestinationTypes.Add(DestinationTypes.Train);

                        }
                    }
                }

            }

            return destinations;

        }

    }
}
