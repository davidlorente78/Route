using System.Collections.Generic;

namespace Traveller.Data
{
    public static class LaosVisas
    {
        public static Visa eLaoVisa = new Visa
        {
            Country = 'L',
            Currency = '$',
            Fee = 50,
            Entries = 'S',
            Name = "Lao eVisa",
            Validity = 60, //An eVisa is valid for maximum of 60 days after receiving the Approval Letter.
            URL = "https://laoevisa.gov.la/index",
            OnLine = true,
            Duration = 30,
            Category = "Tourism",
            Desscription = "Print one copy. No es valido para las entradas por las fronteras terrestres de Camboya, Vietnam y China.",
            Extensible = true,


            ValidEntryPoints = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.Vientiane, LaosDestinations.PAK, LaosDestinations.Savannakhet }
        };


        public static Visa LaoVisa = new Visa
        {
            Country = 'L',
            Desscription = "Lao Visa on arrival",
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
            ValidEntryPoints = new List<Destination> { LaosDestinations.Namkan, LaosDestinations.Taichang }
        };
    }
}
