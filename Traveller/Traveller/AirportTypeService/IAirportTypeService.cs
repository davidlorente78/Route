using Application.Dto;
using Domain.Transport.Aviation;
using DomainServices.Generic;

namespace DomainServices.DestinationService
{
    public interface IAirportTypeService : IGenericService<AirportTypeDto, AirportType>
    {

    }
}