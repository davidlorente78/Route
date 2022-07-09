namespace Traveller.Domain
{
    public class Visa
    {

      
        public int VisaID { get; set; }
        public string Name { get; set; }
        public char CountryCode { get; set; }
        public string? Description { get; set; }

        public bool? OnLine { get; set; }
        public bool? OnArrival { get; set; }
        public string? URL { get; set; }

        public int? Duration { get; set; }
        public char? Entries { get; set; }
        public string? Category { get; set; }
        public int? Validity { get; set; }
        public bool? Extensible { get; set; }
        public int? ExtensionDays { get; set; }

        public char? CurrencyFee { get; set; }
        public int? ExtensionFee { get; set; }

        public int? AdditionalDaysFee { get; set; }
         


        public char? Currency { get; set; }
        public int? Fee { get; set; }

        public string? QualifyNationalities { get; set; }




}
}
