using Domain;
using Data.Nationalities;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class SriLankaVisas
    {
        public static Visa VisaExemption = new Visa
        {           
            Currency = "USD",
            Fee = 0,
            Entries = 'S',
            Description = "Si desea visitar Sri Lanka por un período corto por alguno de los siguientes motivos, deberá obtener la ETA antes de su llegada.",
            Name = "ETA",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = true,
            QualifyNationalities = new List<Nationality> { Nationalities.ES},
            URL = "http://www.eta.gov.lk/"
        };

       
    }
}

