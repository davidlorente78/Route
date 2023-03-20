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
        //CountryMapper coutryMapper;
        ICountryRepository specificCountryRepository;

        public CountryService(IUnitOfWork unitOfWork, CountryMapper coutryMapper, IGenericRepository<Country> countryRepository, ICountryRepository specificCountryRepository) : base(unitOfWork, coutryMapper, countryRepository)
        {
            //this.coutryMapper = coutryMapper;
            this.specificCountryRepository = specificCountryRepository;
        }

        public ICollection<CountryDto> GetCountriesOrderedByName()
        {
            //var countries = unitOfWork.CountryRepository.GetCountriesOrderedByName().ToList();
            var countries = specificCountryRepository.GetCountriesOrderedByName().ToList();


            List<CountryDto> countriesDto = genericMapper.mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = specificCountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }
    }
}
