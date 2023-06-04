using Application.Dto.Generic;
using Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace Traveller.Application.Dto
{
    public class VisaDto : GenericDto
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayName("On Line")]
        public bool? OnLine { get; set; }

        [DisplayName("On Arrival")]
        public bool? OnArrival { get; set; }
        public string URL { get; set; }
        public int? Duration { get; set; }
        public char? Entries { get; set; }
        public string Category { get; set; }
        public int Validity { get; set; }
        public bool Extensible { get; set; }

        [DisplayName("Extension Days")]
        public int? ExtensionDays { get; set; }

        [DisplayName("Extension Days")]
        public char? CurrencyFee { get; set; }

        [DisplayName("Currency")]
        public int? ExtensionFee { get; set; }

        [DisplayName("Additional Days Fee")]
        public int? AdditionalDaysFee { get; set; }
        public string? Currency { get; set; }
        public int? Fee { get; set; }

        public ICollection<NationalityDto>? QualifyNationalities { get; set; }
        [DisplayName("Qualify Nationalities")]

        public string QualifyNationalitiesSummary { get; set; }

    }
}
