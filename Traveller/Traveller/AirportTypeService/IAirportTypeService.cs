using Domain.Transport.Aviation;
using DomainServices.Generic;
using Traveller.Application.Dto;

namespace DomainServices.DestinationService
{
    public interface IAirportTypeService : IGenericService<AirportTypeDto, AirportType>
    {
    }
}