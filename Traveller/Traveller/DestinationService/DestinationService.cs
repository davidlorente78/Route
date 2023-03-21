using Traveller.Application.Dto;
using AutoMapper;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DomainServices.DestinationService
{
    public class DestinationService : IDestinationService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DestinationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public bool DestinationExists(int id)
        {
            return (unitOfWork.DestinationRepository?.Find(e => e.DestinationID == id)).Count() != 0;
        }

        public ICollection<DestinationDto> GetAllDestinations()
        {
            var destinations = unitOfWork.DestinationRepository.GetAllDestinationsOrderByName().ToList();

            return mapper.Map<List<DestinationDto>>(destinations);
        }

    }
}
