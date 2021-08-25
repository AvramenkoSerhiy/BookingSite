using BookingSite.Data.Entities;
using BookingSite.Data.Repositories.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Impl
{
    class RepositoryOfProduct : Repository<Product, int>, IRepositoryOfProduct
    {

        public RepositoryOfProduct(DBContextOfApp dBContext) : base(dBContext)
        {
        }

        public IEnumerable<Product> GetProudctsByStore(int storeId)
        {
            return _entities.Where(product => product.StoreId == storeId);
        }

        public IEnumerable<Product> GetProudctsByStoreAndType(int typeId, int storeId)
        {
            return _entities.Where(product => product.TypeOfProductId == typeId && product.StoreId == storeId);
        }

        public IEnumerable<Product> GetProudctsByType(int typeId)
        {
            return _entities.Where(product => product.TypeOfProductId == typeId);
        }

    }
}
