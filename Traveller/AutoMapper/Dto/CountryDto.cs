using Application.Dto.Generic;

namespace Traveller.Application.Dto
{
    public class CountryDto : GenericDto
    {
        public char? Code { get; set; }
        public string Name { get; set; }
        public bool? ShowInDynamicHome { get; set; }
        public int? ShowInDynamicHomeOrder { get; set; }
    }
}
