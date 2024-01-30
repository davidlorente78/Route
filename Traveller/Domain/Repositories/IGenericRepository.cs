using Domain.Generic;
using System.Linq.Expressions;

/// <summary>
/// First up, let’s add a new folder Interfaces in our Domain Project. Why? Because, we will be inverting the dependencies, so that, you can define the interface in the Domain Project, but the implementation can be outside the Domain Project. In this case, the implementations will go the DataAccess.EFCore Project. Thus, your domain layer will not depends on anything, rather, the other layers tend to depend on the Domain Layer’s interface. This is a simple explanation of Dependency Inversion Principle.
/// </summary>
namespace Domain.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> where TEntity : Entity<int>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        //Some people says Update method can NOT be in a repository
        void Update(TEntity entity);
        //https://stackoverflow.com/questions/5376421/ef-including-other-entities-generic-repository-pattern
        IEnumerable<TEntity> Including(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> [] includes);
        public void Dispose();
    }
}
