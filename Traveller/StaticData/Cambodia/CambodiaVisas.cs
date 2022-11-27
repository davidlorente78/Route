using Data.Nationalities;
using Domain;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaVisas
    {
        public static Visa eVisa_Cambodia = new Visa
        {
            Description = "Cambodia eVisa",
            Currency = '$',
            Fee = 36,
            Entries = 'S',
            Name = "Cambodia eVisa",
            OnLine = true,
            Duration = 30,          
            Validity = 90,           
            URL = "https://www.evisa.gov.kh/", 
            Category = "Tourism",
            QualifyNationalities = new List<Nationality> { Nationalities.ES , Nationalities.CN}
            //Exemptions Laos, Malasia, Filipinas, Singapur, Vietnam, Tailandia, Indonesia, Brunei Darussalam, Myanmar

        };
    }
}
