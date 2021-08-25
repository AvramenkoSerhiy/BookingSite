using BookingSite.Data.Entities;
using BookingSite.Data.Repositories.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Impl
{
    public class RepositoryOfTypeOfProduct : Repository<TypeOfProduct, int>, IRepositoryOfTypeOfProduct
    {
        public RepositoryOfTypeOfProduct(DBContextOfApp dBContext) : base(dBContext)
        {
        }
    }
}
