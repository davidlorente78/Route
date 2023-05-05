using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public class DestinationService : GenericService<DestinationDto, Destination>, IDestinationService
    {
        public DestinationService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IDestinationMapper destinationMapper,
            IGenericRepository<Destination> destinationRepository,
            IDestinationRepository specificdestinationRepository)
            : base(unitOfWork, mapper, destinationMapper, destinationRepository)
        {
        }       
    }
}
