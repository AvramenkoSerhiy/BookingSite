using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Abstr
{
    public interface IServiceOfStore
    {
        public IEnumerable<ViewOfStore> GetAllStores();
        public ViewOfStore GetStoreByID(int storeID);
    }
}
