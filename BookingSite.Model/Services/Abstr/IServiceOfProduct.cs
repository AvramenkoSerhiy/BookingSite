using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Abstr
{
    public interface IServiceOfProduct
    {
        public IEnumerable<ViewOfProduct> GetAllProducts();
        public ViewOfProduct GetProductByID(int productID);
        public IEnumerable<ViewOfProduct> GetAllProductsWithSelectedTypeOfProduct(int typeOfProductID);
        public IEnumerable<ViewOfProduct> GetAllProductsInStore(int storeID);
        public IEnumerable<ViewOfProduct> GetAllProductsWithSelectedTypeOfProductAndStore(int typeOFProductID, int storeId);
    }
}
