using System.Linq.Expressions;

/// <summary>
/// First up, let’s add a new folder Interfaces in our Domain Project. Why? Because, we will be inverting the dependencies, so that, you can define the interface in the Domain Project, but the implementation can be outside the Domain Project. In this case, the implementations will go the DataAccess.EFCore Project. Thus, your domain layer will not depends on anything, rather, the other layers tend to depend on the Domain Layer’s interface. This is a simple explanation of Dependency Inversion Principle.
/// </summary>
namespace Domain.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        //Some people says Update method can NOT be in a repository
        void Update(T entity);


    }
}
