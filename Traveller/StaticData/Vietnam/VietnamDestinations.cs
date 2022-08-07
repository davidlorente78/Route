using StaticData;
using StaticData.Vietnam;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamDestinations
    {

        public static Destination MocBai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Moc Bai",  Description ="Localidad fronteriza de Vietnam ccercana a Bavet (Camboya) " };
        public static Destination VingXuong = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Ving Xuong",  Description=" Localidad vietnamita fronteriza y cercana a Kaam Samnor" };
        public static Destination NhapCanh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description ="", Name = "Nhap Canh" };
        public static Destination TayTrang = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Tay Trang", Description = "Ah 13, Na ư, h. Điện Biên, Điện Biên, Vietnam. Tay Trang, de reciente incorporación y con poco tráfico. El acceso al mismo era complicado y largo, si bien los paisajes del Norte de Laos son los más asombrosos de todo el país. La primera ciudad tras cruzar la frontera es Lai Chau, desde donde se puede ir a Sa Pa, un lugar dónde podemos realizar multitud de excursiones por las montañas, arrozales y poblados. Era nuestro preferido en caso de animarnos a ir a Sa Pa." };
        public static Destination LaoBao = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Bao" };
        public static Destination NaMeo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza en Vietnam muy cercana a Tam Coc y Ninh Binh", Name = "Na Meo" };
        public static Destination LaoCai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Cai" };
        public static Destination HaTien = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza en Vietnam cercana a Chau Doc . Utilizado para entrar o salir desde Kampot (Camboya) Delante de la isla de Phu Quoc ", Name = "Ha Tien / Xa Xia" };
        public static Destination CauTreo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Saliendo desde Lak Sao y siguiendo la ruta 8 se llega a esta localidad fronteriza. Da acceso a Vietnam a la altura de Vinh", Name = "Cau Treo / Cao Tree" };

        public static Destination NinhBinh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Ninh Binh", Name = "Ninh Binh" };
        //Si esta relacionada con una estacion tambien debe tener CountryID para evitar conflicto con FK en inicializacion de Base de datos
        public static Destination HoiAn = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Hoi An", Name = "Hoi An" };
        public static Destination PhanThiet = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Phan Thiet", Name = "Phan Thiet" };
        public static Destination QuiNhon = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Qui Nhon", Name = "Qui Nhon" };

        /// Las localidades ligadas a un aeropuerto deben tener tambien informado el CountryID para evitar conflicto con FK
        public static Destination Hanoi = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Name = "Hanoi" };
        public static Destination HoChiMinh = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Name = "Ho Chi Minh" };
        public static Destination Hue = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Hue", };
        public static Destination Danang = new Destination { CountryID = 2,DestinationTypes = new List<DestinationType> { DestinationTypes.Airport , DestinationTypes.Tourism }, Name = "Danang", };
        public static Destination Haiphong = new Destination { CountryID = 2,DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Hai Phong", };
        public static Destination DungQuatBay = new Destination { CountryID = 2,DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Dung Quat Bay", };
        public static Destination PhuQuoc = new Destination { CountryID = 2,DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Phu Quoc Island", };
        public static Destination CanTho = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }, Name = "Can Tho", };
        public static Destination BuonMaThuot = new Destination { CountryID = 2, DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Buon Ma Thuot", LocalName= "Buôn Ma Thuột" };

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
