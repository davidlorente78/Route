using Application.Mapper.Generic;
using Domain;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public interface INationalityMapper : IGenericMapper<NationalityDto, Nationality>
    {
    }
}
