using Application.Dto.Generic;
using Domain.Generic;

namespace Application.Mapper.Generic
{
    public interface IGenericMapper<TDto, TEntity>
        where TDto : GenericDto
        where TEntity : Entity<int>
    {
        TEntity CreateEntityFromDto(TDto dto);
        TEntity UpdateEntityFromDto(TDto dto, TEntity entity);
    }
}
