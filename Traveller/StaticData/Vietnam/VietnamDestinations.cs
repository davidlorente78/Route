using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamDestinations
    {
        public static Destination HAN = new Destination {  DestinationType= DestinationTypes.Airport, Name = "Nội Bài International Airport - Hanoi", CountryCode = 'V' };
        public static Destination SGN = new Destination { DestinationType = DestinationTypes.Airport, Name = "Tan Son Nhat International Airport - Saigon", CountryCode = 'V' };
        public static Destination HUI = new Destination { DestinationType = DestinationTypes.Airport, Name = "Hue Airport", CountryCode = 'V' };
        public static Destination DAD = new Destination { DestinationType = DestinationTypes.Airport, Name = "Danang Airport", CountryCode = 'V' };

        public static Destination MocBai = new Destination { DestinationType = DestinationTypes.Frontier, Name = "Moc Bai",  Description ="Localidad fronteriza de Vietnam ccercana a Bavet (Camboya) ", CountryCode = 'V' };
        public static Destination VingXuong = new Destination { DestinationType = DestinationTypes.Frontier, Name = "Ving Xuong",  Description=" Localidad vietnamita fronteriza y cercana a Kaam Samnor", CountryCode = 'V' };
        public static Destination Hanoi = new Destination { DestinationType = DestinationTypes.Tourism, Name = "Hanoi", CountryCode = 'V' };
        public static Destination HoChiMinh = new Destination { DestinationType = DestinationTypes.Tourism, Name = "Ho Chi Minh", CountryCode = 'V' };
        public static Destination NhapCanh = new Destination { DestinationType = DestinationTypes.Frontier,  Description="", Name = "Nhap Canh", CountryCode = 'V' };
        public static Destination TayTrang = new Destination { DestinationType = DestinationTypes.Frontier, Name = "Tay Trang", Description = "Ah 13, Na ư, h. Điện Biên, Điện Biên, Vietnam. Tay Trang, de reciente incorporación y con poco tráfico. El acceso al mismo era complicado y largo, si bien los paisajes del Norte de Laos son los más asombrosos de todo el país. La primera ciudad tras cruzar la frontera es Lai Chau, desde donde se puede ir a Sa Pa, un lugar dónde podemos realizar multitud de excursiones por las montañas, arrozales y poblados. Era nuestro preferido en caso de animarnos a ir a Sa Pa.", CountryCode = 'V' };
        public static Destination LaoBao = new Destination { DestinationType = DestinationTypes.Frontier, Description = "", Name = "Lao Bao", CountryCode = 'V' };
        public static Destination NaMeo = new Destination { DestinationType = DestinationTypes.Frontier, Description = "Localidad fronteriza en Vietnam muy cercana a Tam Coc y Ninh Binh", Name = "Na Meo", CountryCode = 'V' };
        public static Destination NinhBinh = new Destination { DestinationType = DestinationTypes.Tourism, Description = "Ninh Binh", Name = "Ninh Binh", CountryCode = 'V' };
        public static Destination LaoCai = new Destination { DestinationType = DestinationTypes.Frontier, Description = "", Name = "Lao Cai", CountryCode = 'V' };
        public static Destination HaTien = new Destination { DestinationType = DestinationTypes.Frontier, Description = "Localidad fronteriza en Vietnam cercana a Chau Doc . Utilizado para entrar o salir desde Kampot (Camboya) Delante de la isla de Phu Quoc ", Name = "Ha Tien / Xa Xia", CountryCode = 'V' };
        public static Destination CauTreo = new Destination { DestinationType = DestinationTypes.Frontier, Description = "Saliendo desde Lak Sao y siguiendo la ruta 8 se llega a esta localidad fronteriza. Da acceso a Vietnam a la altura de Vinh", Name = "Cau Treo / Cao Tree", CountryCode = 'V' };

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
