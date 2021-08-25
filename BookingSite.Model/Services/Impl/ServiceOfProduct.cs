using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Impl
{
    public class ServiceOfProduct : IServiceOfProduct
    {
        private List<ViewOfProduct> _products;

        public ServiceOfProduct()
        {
            _products = new List<ViewOfProduct>();
            InitialiseData();
        }

        public IEnumerable<ViewOfProduct> GetAllProducts()
        {
            return _products.ToList();
        }

        public IEnumerable<ViewOfProduct> GetAllProductsInStore(int storeID)
        {
            return _products.Where(product => product.StoreId == storeID);
        }

        public IEnumerable<ViewOfProduct> GetAllProductsWithSelectedTypeOfProduct(int typeOfProductID)
        {
            return _products.Where(product => product.TypeOfProductId == typeOfProductID);
        }

        public ViewOfProduct GetProductByID(int productID)
        {
            return _products.Where(product => product.Id == productID).FirstOrDefault();
        }

        public IEnumerable<ViewOfProduct> GetAllProductsWithSelectedTypeOfProductAndStore(int typeOfProductID, int storeId)
        {
            return _products.Where(product => product.StoreId == storeId).Where(product => product.TypeOfProductId == typeOfProductID);
        }

        private void InitialiseData()
        {
            _products.Add(new ViewOfProduct() { Id = 1, Price = 5, TypeOfProductId = 1, StoreId = 1, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 2, Price = 10, TypeOfProductId = 2, StoreId = 1, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 3, Price = 15, TypeOfProductId = 3, StoreId = 1, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 4, Price = 20, TypeOfProductId = 2, StoreId = 2, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 5, Price = 25, TypeOfProductId = 3, StoreId = 2, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 6, Price = 30, TypeOfProductId = 4, StoreId = 2, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 7, Price = 35, TypeOfProductId = 3, StoreId = 3, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 8, Price = 40, TypeOfProductId = 4, StoreId = 3, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 9, Price = 45, TypeOfProductId = 5, StoreId = 3, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 10, Price = 50, TypeOfProductId = 1, StoreId = 4, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 11, Price = 55, TypeOfProductId = 3, StoreId = 4, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 12, Price = 60, TypeOfProductId = 5, StoreId = 4, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 13, Price = 65, TypeOfProductId = 2, StoreId = 5, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 14, Price = 70, TypeOfProductId = 4, StoreId = 5, DateOfProducing = new DateTime() });
            _products.Add(new ViewOfProduct() { Id = 15, Price = 75, TypeOfProductId = 1, StoreId = 5, DateOfProducing = new DateTime() });

        }
    }
}
