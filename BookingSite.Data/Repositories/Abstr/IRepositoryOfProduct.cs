using BookingSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Abstr
{
    public interface IRepositoryOfProduct : IRepository<Product, int>
    {
        IEnumerable<Product> GetProudctsByStore(int storeId);

        IEnumerable<Product> GetProudctsByType(int typeId);
        IEnumerable<Product> GetProudctsByStoreAndType(int typeId, int storeId);
    }
}
