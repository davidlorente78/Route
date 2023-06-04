using Data.Nationalities;
using Domain;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class IndonesiaVisas
    {
        public static Visa FreeEntryStamp_Indonesia = new Visa
        {
            Currency = "USD",
            Fee = 0,
            Entries = 'S',
            Description = "",
            Name = "Free Entry Stamp",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://come2indonesia.com/es/visado-turista-indonesia-visa-online-extension-voa/"
        };

        public static Visa eVOA_Indonesia = new Visa
        {
            Currency = "IDR",
            Fee = 500000,
            Entries = 'S',
            Description = "",
            Name = "eVOA",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = true,
            //DurationOfExtension
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://molina.imigrasi.go.id/"
        };
    }
}
