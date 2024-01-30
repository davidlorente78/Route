using Domain.Generic;
using Domain.Repositories;
using System.Linq.Expressions;

namespace RouteDataManager.Repositories
{
    /// <summary>
    /// This class will implement the IGenericRepository Interface. We will also inject the ApplicationContext here. This way we are hiding all the actions related to the dbContext object within Repository Classes. Also note that, for the ADD and Remove Functions, we just do the operation on the dbContext object. But we are not yet commiting/updating/saving the changes to the database whatsover. This is not something to be done in a Repository Class. We would need Unit of Work Pattern for these cases where you commit data to the database. 
    /// https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity<int>
    {
        /// <summary>
        /// Let’s say that you have a requirement to insert a new Developer and a new Project within the same transaction. What happens when the new Developer get’s inserted but the Project Repository fails for some reason. In real-world scenarios, this is quite fatal. We will need to ensure that both the repositories work well, before commiting any change to the database. This is exactly why we decided to not include SaveChanges in any of the repostories. Clear?
        /// Rather, the SaveChanges will be available in the UnitOfWork Class.You will get a better idea once you see the impelemntation.
        /// </summary>
        protected readonly ApplicationContext _context;
        private bool _disposed;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public IEnumerable<TEntity> Including(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            return _context.Set<TEntity>().Where(expression).IncludeMultiple(includes);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            //NEW TEST
            _context.Set<TEntity>().Update(entity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
