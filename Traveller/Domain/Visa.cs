using System.ComponentModel;

namespace Traveller.Domain
{
    public class Visa
    {

      
        public int VisaID { get; set; }
        public string Name { get; set; }
        [DisplayName("Country Code")]
        public char CountryCode { get; set; }
        public string? Description { get; set; }
        [DisplayName("On Line")]
        public bool? OnLine { get; set; }
        [DisplayName("On Arrival")]
        public bool? OnArrival { get; set; }
        public string? URL { get; set; }

        public int? Duration { get; set; }
        public char? Entries { get; set; }
        public string? Category { get; set; }
        public int? Validity { get; set; }
        public bool? Extensible { get; set; }
        [DisplayName("Extension Days")]
        public int? ExtensionDays { get; set; }
        [DisplayName("Extension Days")]
        public char? CurrencyFee { get; set; }
        [DisplayName("Currency")]
        public int? ExtensionFee { get; set; }
        [DisplayName("Additional Days Fee")]
        public int? AdditionalDaysFee { get; set; }
         


        public char? Currency { get; set; }
        public int? Fee { get; set; }
        [DisplayName("Qualify Nationalities")]
        public string? QualifyNationalities { get; set; }




}
}
