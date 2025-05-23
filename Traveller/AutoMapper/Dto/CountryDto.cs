﻿using Application.Dto.Generic;
using System.Collections.Generic;

namespace Traveller.Application.Dto
{
    public class CountryDto : GenericDto
    {
        public char Code { get; set; }
        public string Name { get; set; }
        public bool? ShowInDynamicHome { get; set; }
        public int? ShowInDynamicHomeOrder { get; set; }
        public List<VisaDto> Visas { get; set; }
    }
}
