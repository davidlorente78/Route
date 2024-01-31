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
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            return MapToEntity(dto);
        }

        public virtual TEntity UpdateEntityFromDto(TDto dto, TEntity entity)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            foreach (var dtoProperty in typeof(TDto).GetProperties())
            {
                var entityProperty = typeof(TEntity).GetProperty(dtoProperty.Name);

                if (entityProperty != null && entityProperty.CanWrite)
                {
                    var value = dtoProperty.GetValue(dto);
                    entityProperty.SetValue(entity, value);
                }
            }

            return entity;
        }

        private static TEntity MapToEntity(TDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            TEntity entity = Activator.CreateInstance<TEntity>();

            foreach (var dtoProperty in typeof(TDto).GetProperties())
            {
                var entityProperty = typeof(TEntity).GetProperty(dtoProperty.Name);

                if (entityProperty != null && entityProperty.CanWrite)
                {
                    var value = dtoProperty.GetValue(dto);
                    entityProperty.SetValue(entity, value);
                }
            }

            return entity;
        }


    }
}
