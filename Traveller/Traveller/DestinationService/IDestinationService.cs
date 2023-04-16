using DomainServices.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public interface IDestinationService : IGenericService<DestinationDto, Destination>
    {
    }
}