using Data.Nationalities;
using Domain;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class ThailandVisas
    {
        public static Visa VisaExemption_Thailand = new Visa
        {
            Currency = "USD",
            Fee = 0,
            Entries = 'S',
            Description = "Holders of normal passports of the following countries are granted visa-free travel to Thailand for a period of up to 30 days. The exemption is granted at most twice in a calendar year when entering over land or via a sea border but there is no limitation when entering by air. For Malaysians entering by land border, there is no limitation in issuing the 30-day visa exemption stamp.",
            Name = "Visa Exemption",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://madrid.thaiembassy.org/en/index"
        };

        public static Visa VisaOnArrival = new Visa
        {
            Description = "Passport holders of some countries / territories may apply for Visa on Arrival.",
            Name = "Visa on Arrival",
            OnArrival = true,
            Duration = 15,
            QualifyNationalities = new List<Nationality> { Nationalities.CN },
        };

        public static Visa eVisa = new Visa
        {
            Description = "Non-Thai nationals who wish to apply for a Thai visa must apply and submit the application through the new online e-Visa platform at https://www.thaievisa.go.th. Please note that it is no longer required for the applicant to submit his/her passport and original supporting documents in person at the Embassy.",
            Name = "eVisa",
            Duration = 30,
            OnArrival = false,
            QualifyNationalities = new List<Nationality> { Nationalities.CN },

            URL = "https://www.thaievisa.go.th/"
        };
        ///Visado (expedido por la Embajada de Tailandia o por los Consulados de representación) es necesario sólo si la estancia en el país es superior a 30 días.
    }
}
