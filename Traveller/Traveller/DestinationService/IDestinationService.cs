using Traveller.Application.Dto;
using System.Collections.Generic;
using DomainServices.Generic;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public interface IDestinationService : IGenericService<DestinationDto, Destination>
    {
        ICollection<DestinationDto> GetAll();      
    }
}