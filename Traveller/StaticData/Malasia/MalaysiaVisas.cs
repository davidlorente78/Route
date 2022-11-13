using Domain;
using Data.Nationalities;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalaysiaVisas
    {
        public static Visa freeVisa_Malaysia = new Visa
        {
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Name = "Free visa for stays of less than 90 days",
            Validity = 0,
            OnLine = false,
            OnArrival = true,
            Duration = 90,
            Category = "Free visa for stays of less than 90 days.",
            Extensible = true,
            QualifyNationalities = new List<Nationality> { Nationalities.ES}

            //ValidEntryPoints = new List<Destination> { MalasiaDestinations.PadangPesar, MalasiaDestinations.RantanPanjang }
        };


        //Foreign National from these countries are eligible to apply:

        public static Visa eVisa_Malaysia = new Visa
        {
            Currency = '$',
            Fee = 0,
            // Single Entry Visa (SEV) to all nationalities except for Israel and North Korea for a single 
            //journey to Malaysia subjected to eligibility of nationality for each visit with NO extensions allowed
            Entries = 'S',
            Name = "eVisa",
            Description = "eVISA is an online application platform that enable foreign nationals to apply for an electronic visa to enter Malaysia at the comfort of their convenience.",

            //eVISA is valid for 3 months from the date of issuance. 
            Validity = 90,
            //. If you are travelling in another country on vacation and holding a tourist visa 
            //  of that country, you cannot apply eVISA online.It is advisable to apply your eVISA in your country of origin 
            // if you are planning to return to your country of origin at the end of your travel.Otherwise, your other
            //alternative is applying a normal visa at the High Commission,  Consulate or Embassy of Malaysia nearest to you
            OnLine = true,
            OnArrival = false,
            Duration = 30,            
            Extensible = false,
            QualifyNationalities = new List<Nationality> { Nationalities.CN },
            URL = "https://malaysiavisa.imi.gov.my/evisa/evisa.jsp"

            //ValidEntryPoints = new List<Destination> { MalasiaDestinations.PadangPesar, MalasiaDestinations.RantanPanjang }
        };


    }
}
