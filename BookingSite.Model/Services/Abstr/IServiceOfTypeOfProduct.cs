using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Abstr
{
    public interface IServiceOfTypeOfProduct
    {
        public IEnumerable<ViewOfTypeOfProduct> GetAllTypesOfProduct();
        public ViewOfTypeOfProduct GetTypesOfProductByID(int typeOfProductId);
        public IEnumerable<ViewOfTypeOfProduct> FindByName(string name);
    }
}
