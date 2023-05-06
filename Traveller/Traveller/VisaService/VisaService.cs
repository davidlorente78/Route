using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class VisaService : GenericService<VisaDto, Visa>, IVisaService
    {
        private ICountryService countryService;
        private IVisaRepository specificVisaRepository;

        public VisaService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IVisaMapper visaMapper,
            IGenericRepository<Visa> visaRepository,
            IVisaRepository specificVisaRepository,
            ICountryService countryService)
            : base(unitOfWork, mapper, visaMapper, visaRepository)
        {
            this.specificVisaRepository = specificVisaRepository;
            this.countryService = countryService;
        }

        public int GetMaxStay(char countryCode, string nationalityCode)
        {
            var country = countryService
                .GetIncluding(c => c.Code == countryCode, c => c.Visas)
                .FirstOrDefault();

            var maxStay = 0;

            if (country.Visas.Count() != 0)
            {
                maxStay = specificVisaRepository.GetMaxStay(country.Id, nationalityCode);
            }

            return maxStay;
        }
    }
}
