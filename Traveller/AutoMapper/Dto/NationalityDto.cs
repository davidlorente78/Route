using Application.Dto.Generic;
using Traveller.Domain;

namespace Traveller.Application.Dto
{
    public class NationalityDto : GenericDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
