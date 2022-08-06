using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamDestinations
    {
        public static Destination HAN = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Nội Bài International Airport - Hanoi" };
        public static Destination SGN = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Tan Son Nhat International Airport - Saigon", };
        public static Destination HUI = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Hue Airport", };
        public static Destination DAD = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Name = "Danang Airport",  };

        public static Destination MocBai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Moc Bai",  Description ="Localidad fronteriza de Vietnam ccercana a Bavet (Camboya) " };
        public static Destination VingXuong = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Ving Xuong",  Description=" Localidad vietnamita fronteriza y cercana a Kaam Samnor" };
        public static Destination Hanoi = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Name = "Hanoi" };
        public static Destination HoChiMinh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Name = "Ho Chi Minh" };
        public static Destination NhapCanh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description ="", Name = "Nhap Canh" };
        public static Destination TayTrang = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Name = "Tay Trang", Description = "Ah 13, Na ư, h. Điện Biên, Điện Biên, Vietnam. Tay Trang, de reciente incorporación y con poco tráfico. El acceso al mismo era complicado y largo, si bien los paisajes del Norte de Laos son los más asombrosos de todo el país. La primera ciudad tras cruzar la frontera es Lai Chau, desde donde se puede ir a Sa Pa, un lugar dónde podemos realizar multitud de excursiones por las montañas, arrozales y poblados. Era nuestro preferido en caso de animarnos a ir a Sa Pa." };
        public static Destination LaoBao = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Bao" };
        public static Destination NaMeo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza en Vietnam muy cercana a Tam Coc y Ninh Binh", Name = "Na Meo" };
        public static Destination NinhBinh = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }, Description = "Ninh Binh", Name = "Ninh Binh" };
        public static Destination LaoCai = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "", Name = "Lao Cai" };
        public static Destination HaTien = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Localidad fronteriza en Vietnam cercana a Chau Doc . Utilizado para entrar o salir desde Kampot (Camboya) Delante de la isla de Phu Quoc ", Name = "Ha Tien / Xa Xia" };
        public static Destination CauTreo = new Destination { DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description = "Saliendo desde Lak Sao y siguiendo la ruta 8 se llega a esta localidad fronteriza. Da acceso a Vietnam a la altura de Vinh", Name = "Cau Treo / Cao Tree" };

        public static ICollection<Destination> GetAll()
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
                HAN,SGN,HUI,DAD
            
            };
        }

      
    }
}
