using DomainServices.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public interface IDestinationTypeService : IGenericService<DestinationTypeDto, DestinationType>
    {
        //YOU ARE HERE
        //ICollection<DestinationDto> GetAll();      
    }
}