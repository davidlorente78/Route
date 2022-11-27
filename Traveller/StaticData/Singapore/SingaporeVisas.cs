using Data;
using Data.Nationalities;
using Domain;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class SingaporeVisas
    {
        public static Visa SGArrivalCard_Singapore = new Visa
        {
            
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Description = "Todas las personas con pasaporte español que deseen acceder a Singapur, deberán solicitar previamente a su entrada una tarjeta electrónica de desembarque conocida como SG Arrival Card. Es de una entrada y su validez comenzará desde la fecha que hayamos indicado a la hora de realizar la solicitud.  ",
            Name = "SG Arrival Card (SGAC) ",
            Validity = 0,
            OnLine = true,
            OnArrival = false,
            Duration = 30,
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://www.ica.gov.sg/"
        };
    }
}
