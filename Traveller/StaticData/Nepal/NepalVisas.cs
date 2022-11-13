using Domain;
using Data.Nationalities;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class NepalVisas
    {
        public static Visa OnArrivalVisa15_Nepal = new Visa
        {
           
            Currency = '$',
            Fee = 30,
            Entries = 'S',
            Description = "Tourist visa is extended not exceeding total  150 days of stay in a single visa year (Jan-Dec)",
            Name = "On Arrival Visa 15 days",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 15,
            Extensible = true,
            AdditionalDaysFee = 3,
            QualifyNationalities = new List<Nationality> { Nationalities.ES},
            URL = "https://www.immigration.gov.np/page/visa-on-arrival"

        };


        public static Visa OnArrivalVisa30_Nepal= new Visa
        {
          
            Currency = '$',
            Fee = 50,
            Entries = 'S',
            Description = "Tourist visa is extended not exceeding total  150 days of stay in a single visa year (Jan-Dec)",
            Name = "On Arrival Visa 30 days",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 30,
            Extensible = true,
            AdditionalDaysFee = 3,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://www.immigration.gov.np/page/visa-on-arrival"

        };

        public static Visa OnArrivalVisa90_Nepal = new Visa
        {
           
            Currency = '$',
            Fee = 125,
            Entries = 'S',
            Description = "Tourist visa is extended not exceeding total  150 days of stay in a single visa year (Jan-Dec)",
            Name = "On Arrival Visa 90 days",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 90,
            Extensible = true,
            AdditionalDaysFee = 3,
            QualifyNationalities = new List<Nationality> { Nationalities.ES },
            URL = "https://www.immigration.gov.np/page/visa-on-arrival"

        };

        public static Visa FreeVisa_Nepal = new Visa
        {
           
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Description = "Chinese Nationals are eligible for 150 days tourist Gratis Visa in a given visa year",
            Name = "Free Visa",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 150,
            Extensible = false,            
            QualifyNationalities = new List<Nationality> { Nationalities.CN },
            URL = "https://www.immigration.gov.np/page/visa-on-arrival"

        };


        //On Arrival Visa Fee at Entry Points

        //15 Days – 30 USD

        //30 Days – 50 USD

        //90 Days – 125 USD

        //3rd Step
        //Proceed to the Immigration Desk with your online form,  payment receipts and your passport
        //Hand in your documents to immigration officer for visa processing.He/she issues visa to you upon his/her satisfaction.
        //Visa Extension Fee

        //Tourist visa extension is done for minimum 15 days with USD 45 and USD 3 per day for additional days.
        //In the case of delay less than 150 days additional USD 5 per day as late fine.
    }


}

