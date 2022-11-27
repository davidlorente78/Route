using AutoMapper;
using RouteDataManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class CountryService : ICountryService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }

        public bool CountryExists(int id)
        {
            return (unitOfWork.ICountryRepository?.Find(e => e.CountryID == id)).Count() != 0;
        }

        public ICollection<CountryDto> GetAllCountries()
        {
            var countries = unitOfWork.ICountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }
        
        public CountryDto GetCountryByID(int ID)
        {
            var country = unitOfWork.ICountryRepository.GetCountryByID(ID).FirstOrDefault();
            CountryDto countryDto = mapper.Map<CountryDto>(country);

            return countryDto;
        }

        public ICollection<CountryDto> GetCountries()
        {
            var countries = unitOfWork.ICountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);
            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {            
            var country = unitOfWork.ICountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }

        public int AddCountry(Country country)
        {            
           unitOfWork.ICountryRepository.Add(country);

           return unitOfWork.SaveChanges();
        }

        public int RemoveCountry(CountryDto countryDto)
        {
            var country = GetCountryEntityByID(countryDto.CountryID);
            unitOfWork.ICountryRepository.Remove(country);
            return unitOfWork.SaveChanges();
        }

        private Country CreateEntityFromDto(CountryDto countryDto)
        {
            Country country = mapper.Map<Country>(countryDto);
            return country;
        }

        public int UpdateCountry(Country country)
        {
            unitOfWork.ICountryRepository.Update(country);

            return unitOfWork.SaveChanges();
        }

        private Country GetCountryEntityByID(int ID)
        {
            var country = unitOfWork.ICountryRepository.GetCountryByID(ID).FirstOrDefault();

            return country;
        }

    }
}
