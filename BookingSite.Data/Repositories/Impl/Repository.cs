using BookingSite.Data.Entities;
using BookingSite.Data.Repositories.Abstr;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Impl
{
    public class Repository<T, KId> : IRepository<T, KId> where T : BaseEntity<KId>
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _entities;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public T GetById(KId id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsNoTracking();
        }
    }
}
