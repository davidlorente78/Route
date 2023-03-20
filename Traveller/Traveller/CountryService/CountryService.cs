using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.GenericService;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class CountryService : GenericService<CountryDto, Country>, ICountryService
    {
        CountryMapper coutryMapper;

        public CountryService(IUnitOfWork unitOfWork, CountryMapper coutryMapper, IGenericRepository<Country> countryRepository) : base(unitOfWork, coutryMapper, countryRepository)
        {
            this.coutryMapper = coutryMapper;
        }

        public ICollection<CountryDto> GetCountriesOrderedByName()
        {
            var countries = unitOfWork.CountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = genericMapper.mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = unitOfWork.CountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }
    }
}
