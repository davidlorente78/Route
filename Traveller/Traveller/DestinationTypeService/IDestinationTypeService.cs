using Traveller.Application.Dto;
using System.Collections.Generic;
using DomainServices.Generic;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public interface IDestinationTypeService : IGenericService<DestinationTypeDto, DestinationType>
    {
        //YOU ARE HERE
        //ICollection<DestinationDto> GetAll();      
    }
}