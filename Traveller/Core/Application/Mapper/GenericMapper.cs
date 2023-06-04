using AutoMapper;
using Core.Application.Dto;
using Core.Domain;

namespace Application.Mapper.Generic
{
    public class GenericMapper<TDto, TEntity> : IGenericMapper<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity
    {
        public readonly IMapper mapper;

        public GenericMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public virtual TEntity CreateEntityFromDto(TDto dto)
        {
            TEntity entity = mapper.Map<TEntity>(dto);
            return entity;
        }

        public virtual TEntity UpdateEntityFromDto(TDto dto, TEntity entity)
        {
            entity.Id = dto.Id;
            return entity;
        }
    }
}
