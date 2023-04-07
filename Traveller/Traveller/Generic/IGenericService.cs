using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DomainServices.Generic
{
    public interface IGenericService<TDto, TEntity>
    {
        ICollection<TDto> GetAll();
        TDto GetByID(int ID);
        bool Exists(int id);
        int Add(TDto dto);
        int Remove(int id);
        int Update(TDto dto);
        ICollection<TDto> GetIncluding(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
    }
}