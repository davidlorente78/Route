using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosVisas
    {
        /// <summary>
        /// eVisa can be used to enter through these following designated ports:

        //1.             Wattay International Airport(Vientiane Capital)

        //2.             Lao – Thai Friendship Bridge I(Vientiane Capital)

        //3.             Luang Prabang International Airport(Luang Prabang)

        //4.             Lao – Thai Friendship Bridge II(Savannakhet Province)

        //5.             Pakse International Airport(Champasack Province)

        //Nationalities https://laoevisa.gov.la/article/who_can_apply

        /// </summary>
        public static Visa eLaoVisa = new Visa
        {
            CountryCode = 'L',
            Currency = '$',
            Fee = 50,
            Entries = 'S',
            Name = "Lao eVisa",
            Validity = 60, //An eVisa is valid for maximum of 60 days after receiving the Approval Letter.
            URL = "https://laoevisa.gov.la/index",
            OnLine = true,
            Duration = 30,
            Category = "Tourism",
            Description = "Print one copy. No es valido para las entradas por las fronteras terrestres de Camboya, Vietnam y China.",
            Extensible = true,
            
        };

       
        public static Visa LaoVisa = new Visa
        {
            CountryCode = 'L',
            Description = "Lao Visa on arrival",
            Currency = '$',
            Fee = 50,
            Entries = 'S',
            Name = "Lao Visa",
            OnLine = false,
            Duration = 30,
            Extensible = true,
            ExtensionDays = 30,
            ExtensionFee = 35,
            URL = "", //TODO Enlace para verificar que pasos estan abiertos en todo momento
            Category = "Tourism",
           
        };
    }
}
