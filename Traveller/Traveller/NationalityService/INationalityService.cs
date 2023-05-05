using Domain;
using DomainServices.Generic;
using Traveller.Application.Dto;

namespace Traveller.DomainServices
{
    public interface INationalityService : IGenericService<NationalityDto, Nationality>
    {
    }
}