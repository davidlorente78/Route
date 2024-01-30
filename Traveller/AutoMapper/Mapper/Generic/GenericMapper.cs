using Application.Dto.Generic;
using AutoMapper;
using Domain.Generic;
using System;

namespace Application.Mapper.Generic
{
    public class GenericMapper<TDto, TEntity> : IGenericMapper<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity<Int32>

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
