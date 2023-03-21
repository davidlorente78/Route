using System.Collections.Generic;

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
    }
}