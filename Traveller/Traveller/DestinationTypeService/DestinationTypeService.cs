using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public class DestinationTypeService : GenericService<DestinationTypeDto, DestinationType>, IDestinationTypeService
    {
        public DestinationTypeService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IDestinationTypeMapper destinationTypeMapper,
            IGenericRepository<DestinationType> destinationTypeRepository,
            IDestinationRepository specificdestinationRepository)
            : base(unitOfWork, mapper, destinationTypeMapper, destinationTypeRepository)
        {
        }
    }
}
