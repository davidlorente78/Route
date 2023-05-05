using DomainServices.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface IVisaService : IGenericService<VisaDto, Visa>
    {
        public int GetMaxStay(char countryCode, string nationalityCode);
    }
}
