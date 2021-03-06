using BookingSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Abstr
{
    public interface IRepository<T, KId> where T : BaseEntity<KId>
    {
        void Create(T item);
        T GetById(KId id);
        IEnumerable<T> GetAll();
        void Delete(T item);
        void Update(T item);
    }
}
