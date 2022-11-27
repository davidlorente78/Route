using Application.Dto;
using AutoMapper;
using RouteDataManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
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
            return (unitOfWork.IDestinationRepository?.Find(e => e.DestinationID == id)).Count() != 0;
        }

        public ICollection<DestinationDto> GetAllDestinations()
        {
            var destinations = unitOfWork.IDestinationRepository.GetAllDestinationsOrderByName().ToList();         

            return mapper.Map<List<DestinationDto>>(destinations);
        }       
    
    }
}
