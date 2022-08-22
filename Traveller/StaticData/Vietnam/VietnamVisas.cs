using Domain;
using StaticData.Nationalities;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamVisas
    {
        public static Visa eVisa_Vietnam = new Visa
        {
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Description = "The eVisa is an electronic visa that allows you a Single Entry to Vietnam for a period of time not exceeding 30 consecutive days.",   
            Name = "eVisa",
            Validity = 0,
            OnLine = true,
            OnArrival = false,
            Duration = 30,
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.ES , Nationalities.CN },
            URL = "https://e-visado.es/vietnam/requisitos"

            //TODO
            //Por vía aérea
            //Nombre aeropuerto
            //Cam Ranh(Khanh Hoa)    Can Tho Cat Bi International Airport(Hai Phong)
            //Da Nang International Airport   Noi Bai International Airport(Ha Noi)  Phu Bai International Airport
            //Phu Quoc International Airport  Tan Son Nhat International Airport(Ho Chi Minh City)
            //Por vía terrestre
            //Nombre paso fronterizo
            //Bo Y    Cau Treo    Cha Lo
            //Ha Tien Huu Nghi    La Lay
            //Lao Bao Lao Cai Moc Bai
            //Mong Cai    Na Meo  Nam Can
            //Song Tien   Tay Trang   Tinh Bien
            //Xa Mat
            //Por vía marítima
            //Nombre puerto marítimo
            //Chan May Seaport    Da Nang Seaport Duong Dong Seaport
            //Hai Phong Seaport   Ho Chi Minh City Seaport    Hon Gai Seaport
            //Nha Trang Seaport   Quy Nhon Seaport    Vung Tau Seaport

        };

        public static Visa VisaExemption_Vietnam = new Visa
        {
            Currency = '$',
            Fee = 25,
            Entries = 'S',
            Description = "If you want to re-enter Vietnam after using a visa waiver, you must wait 30 days outside Vietnam or apply for an eVisa." ,
            Name = "Visa Exemption",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 15,
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://e-visado.es/vietnam/requisitos"

        };
    }
}
