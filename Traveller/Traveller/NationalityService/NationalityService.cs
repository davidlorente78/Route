using Application.Dto;
using Application.Mapper;
using AutoMapper;
using Domain;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class NationalityService : GenericService<NationalityDto, Nationality>, INationalityService
    {
        INationalityRepository specificNationalityRepository;

        public NationalityService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            INationalityMapper nationalityMapper,
            IGenericRepository<Nationality> nationalityRepository,
            INationalityRepository specificNationalityRepository)
            : base(unitOfWork, mapper, nationalityMapper, nationalityRepository)
        {
            this.specificNationalityRepository = specificNationalityRepository;
        }

        public Nationality GetByCode(string code)
        {
            var nationality = specificNationalityRepository.GetByCode(code);

            return nationality;
        }
    }
}
