using Domain;
using Data.Nationalities;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class PhilippinesVisas
    {
        public static Visa VisaExemption = new Visa
        {           
            Currency = "USD",
            Fee = 0,
            Entries = 'S',
            Description = "No visa required for a stay not exceeding thirty (30) days. Traveller must hold valid ticket for return journey to country of origin or next country of destination and a passport valid for a period of at least six (6) months beyond the stay in the Philippines.",
            Name = "Visa Exemption",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = true,
            QualifyNationalities = new List<Nationality> { Nationalities.ES},
            URL = "https://www.visa.gov.ph/"
        };

       
    }
}

