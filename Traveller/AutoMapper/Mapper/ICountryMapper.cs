using Application.Mapper.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public interface ICountryMapper : IGenericMapper<CountryDto, Country>
    {
    }
}
